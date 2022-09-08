﻿using Core.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EtityFramework;
using DataAccess.Abstarct;

namespace DataAccess.Concrete.EntityFramework
{
  public class EfUserDal : EfEntityRepositoryBase<User, ReCapContext>, IUserDal
  {
    public List<OperationClaim> GetClaims(User user)
    {
      using (var context = new ReCapContext())
      {
        var result = from operationClaim in context.OperationClaims
                     join userOperationClaim in context.UsersOperationClaims
                         on operationClaim.Id equals userOperationClaim.OperationClaimId
                     where userOperationClaim.UserId == user.Id
                     select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
        return result.ToList();

      }
    }
  }
}
