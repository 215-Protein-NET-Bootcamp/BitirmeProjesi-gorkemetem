using Base;
using NUnit.Framework;

namespace Test
{
    public class HashingHelperTests
    {
        private byte[] passwordSalt;
        private string password = "12345";
        private byte[] passwordHash;

        [Test]
        public void CreateAndVerifyPassword()
        {
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            Assert.IsTrue(HashingHelper.VerifyPasswordHash(password, passwordHash, passwordSalt));    
        }
    }
}