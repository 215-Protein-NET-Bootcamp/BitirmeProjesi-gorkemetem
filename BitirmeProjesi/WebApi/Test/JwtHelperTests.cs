using Base;
using NUnit.Framework;
using System.Collections.Generic;

namespace Test
{
    public class JwtHelperTests
    {
        public User _user = new User
        {
            Id = 1,
            FirstName = "Test",
            LastName = "Test",
            Email = "etem@etem.com",
            Status = true
        };

        public OperationClaim _claim = new OperationClaim
        {
            Id = 1,
            Name = "user"
        };

        


        [Test]
        public void CreateToken()
        {
            List<OperationClaim> operationClaims = new List<OperationClaim>();
            operationClaims.Add(_claim);
            //JwtHelper.CreateToken(_user, operationClaims);
        }
    }
}