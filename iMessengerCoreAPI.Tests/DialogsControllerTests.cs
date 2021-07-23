using iMessengerCoreAPI.Controllers;
using iMessengerCoreAPI.Models;
using iMessengerCoreAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace iMessengerCoreAPI.Tests
{
    public class DialogsControllerTests
    {
        [Fact]
        public void GetDialogIDTest()
        {
            var result = new RepositoryDialogs()
                .FindDialogID(GetClientsId());
            Assert.Equal(new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f"),
                result);
        }
        [Fact]
        public void GetEmptyDialogIDTest()
        {
            var result = new RepositoryDialogs()
                .FindDialogID(GetClientsIdForEmpty());
            Assert.Equal(new Guid(),
                result);
        }


        private List<Guid> GetClientsId()
        {
            var IDClient4 = new Guid("0a58955e-342f-4095-88c6-1109d0f70583");
            var list = new List<Guid>();
            list.Add(IDClient4);
            return list;
        }

        private List<Guid> GetClientsIdForEmpty()
        {
            var IDClient1 = new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151");
            var IDClient2 = new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820");
            var IDClient5 = new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820");
            return new() { IDClient1, IDClient2, IDClient5 };
        }

    }
}
