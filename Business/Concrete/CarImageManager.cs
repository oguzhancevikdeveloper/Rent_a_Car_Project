using Business.Abstarct;
using Business.Constant;
using Core.DataAccess.Utilities.Results;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using DataAccess.Abstarct;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
  public class CarImageManager : ICarImageService
  {
    ICarImageDal _carImageDal;
    IFileHelper _fileHelper;

    public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
    {
      _carImageDal = carImageDal;
      _fileHelper = fileHelper;
    }

    public IResult Add(IFormFile formFile, CarImage carImage)
    {
      BusinessRule.Run(CheckCarImageCount(carImage.CarId));
      carImage.ImagePath = _fileHelper.Add(formFile, PathConstants.ImagesRoot);
      carImage.Date = DateTime.Now;
      _carImageDal.Add(carImage);
      return new SuccessResult(Messages.SuccessUploadOfCarImage);
    }

    public IResult Delete(CarImage carImage)
    {
      _fileHelper.Delete(PathConstants.ImagesRoot + carImage.ImagePath);
      _carImageDal.Delete(carImage);
      return new SuccessResult(Messages.CarImageDeletedSuccessfully);
    }

    public IDataResult<List<CarImage>> GetAll()
    {
      return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(),Messages.GetAllCarImage);
    }

    public IDataResult<List<CarImage>> GetByCarId(int carId)
    {
      var result = BusinessRule.Run(CheckHaveCarImage(carId));
      if (result != null)
      {
        return new ErrorDataResult<List<CarImage>>(GetDefaultCarImage(carId).Data);
      }
      return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
    }

    public IDataResult<List<CarImage>> GetByImageId(int imageId)
    {
      return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.Id == imageId));
    }

    public IResult Update(IFormFile formFile, CarImage carImage)
    {
      carImage.ImagePath = _fileHelper.Update(formFile, PathConstants.ImagesRoot + carImage.ImagePath, PathConstants.ImagesRoot);
      carImage.Date = DateTime.Now;
      _carImageDal.Update(carImage);
      return new SuccessResult(Messages.CarImageUpdatedSuccesfully);
    }

    private IResult CheckCarImageCount(int carId)
    {
      var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
      if (result > 5)
      {
        return new ErrorResult(Messages.CarImageCountExceeded);
      }
      return new SuccessResult();
    }
    private IResult CheckHaveCarImage(int carId)
    {
      var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
      if (result > 0)
      {
        return new SuccessResult();
      }
      return new ErrorResult();
    }
    private IDataResult<List<CarImage>> GetDefaultCarImage(int carId)
    {
      List<CarImage> defaultCarImages = new List<CarImage>();
      defaultCarImages.Add(new CarImage { CarId = carId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
      return new SuccessDataResult<List<CarImage>>(defaultCarImages);
    }
  }
}
