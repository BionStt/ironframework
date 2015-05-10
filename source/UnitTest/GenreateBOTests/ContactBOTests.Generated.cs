// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactBOTests.cs" company="Megadotnet">
// Copyright (c) 2010-2015 Peter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   The ContactTests
//   This file is auto generated and will be overwritten as soon as the template is executed
//   Do not modify this file...
// </summary>
// --------------------------------------------------------------------------------------------------------------------	
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using BusinessEntities;
using Xunit;
using Xunit.Extensions;
using Ploeh.AutoFixture.Xunit;
using DataTransferObject;
using BusinessObject;
using DataAccessObject;
	
namespace UnitTest.GenreateBOTests
{   
    /// <summary>
    /// Contact Tests object
    /// </summary>
	public partial class ContactBOTests
	{       
        #region BoTest

        /// <summary>
        /// Tests the add.
        /// </summary>
        /// <param name="_ContactDto">The Contact dto.</param>
        [Theory, AutoData, AutoRollback]
        public void TestAdd(ContactDto _ContactDto)
        {
            var _ContactBO = new ContactBO();
            bool hasAdded=_ContactBO.CreateEntiy(_ContactDto);
            Assert.True(hasAdded);
        }

	    /// <summary>
        ///GetEntiyByPK
        /// </summary>
        /// <param name="pkid">The PK int</param>
        [Theory, AutoData]
        public void TestGetEntiyByPK(int pkid)
        {
            var _ContactBO = new ContactBO();
            var dbResult = _ContactBO.GetEntiyByPK(pkid);
            Assert.NotNull(dbResult);
        }

        /// <summary>
        /// Tests the get.
        /// </summary>
        /// <param name="_ContactDto">The _Contact dto.</param>
        [Theory, AutoData]
        public void TestFindAll(ContactDto _ContactDto)
        {
            var _ContactBO = new ContactBO();
            var dbResult=_ContactBO.FindAll(_ContactDto);
            Assert.NotNull(dbResult);
		    Assert.True(dbResult.Total>0);
        }

		/// <summary>
        /// Tests the get.
        /// </summary>
        /// <param name="_ContactDto">The _Contact dto.</param>
        [Theory, AutoData]
        public void TestFindEnties(ContactDto _ContactDto)
        {
            var _ContactBO = new ContactBO();
            var dbResult=_ContactBO.FindEnties(_ContactDto);
            Assert.NotNull(dbResult);
			Assert.True(dbResult.Total>0);
        }

        /// <summary>
        /// Tests the get.
        /// </summary>
        /// <param name="_ContactDto">The _Contact dto.</param>
        [Theory, AutoData]
        public void TestFindEntiesWithSimplePaging(int? pageIndex, int pageSize)
        {
             var _ContactBO = new ContactBO();
            var dbResult = _ContactBO.FindEnties(pageIndex, pageSize);
            Assert.NotNull(dbResult);
			Assert.True(dbResult.Count>0);
        }

		/// <summary>
        /// TestUpdateEntiyWithGet
        /// </summary>
        /// <param name="_ContactDto"></param>
        [Theory, AutoData, AutoRollback]
        public void TestUpdateEntiyWithGet(ContactDto _ContactDto)
        {
            var _ContactBO = new ContactBO();
            var dbResult = _ContactBO.UpdateEntiyWithGet(_ContactDto);
            Assert.NotNull(dbResult);
        }

        /// <summary>
        /// Tests the update with attach entiy.
        /// </summary>
        /// <param name="_ContactDto">The Contact.</param>
        [Theory, AutoData, AutoRollback]
        public void TestUpdateWithAttachEntiy(ContactDto _ContactDto)
        {
            var _ContactBO = new ContactBO();
            bool isUpdated = _ContactBO.UpdateWithAttachEntiy(_ContactDto);
            Assert.True(isUpdated);
        }

        /// <summary>
        /// Tests the delete with attach entiy.
        /// </summary>
        /// <param name="_ContactDto">The Contact dto.</param>
        [Theory, AutoData, AutoRollback]
        public void TestDeleteWithAttachEntiy(ContactDto _ContactDto)
        {
            var _ContactBO = new ContactBO();
            bool isDeleted = _ContactBO.DeleteWithAttachEntiy(_ContactDto);
            Assert.True(isDeleted);
        }

		/// <summary>
        /// TestDeleteEntiy
        /// </summary>
        /// <param name="_ContactDto">_ContactDto</param>
        [Theory, AutoData, AutoRollback]
        public void TestDeleteEntiy(ContactDto _ContactDto)
        {
            var _ContactBO = new ContactBO();
            bool isDeleted = _ContactBO.DeleteEntiy(_ContactDto);
            Assert.True(isDeleted);
        }

        #endregion

        /// <summary>
        /// Tests the Contact repository add.
        /// </summary>
        /// <param name="_Contact">The _ Contact.</param>
        [Theory, AutoData, AutoRollback]
        public void TestContactRepositoryAdd(Contact _Contact)
        {
            var _ContactRepository = RepositoryHelper.GetContactRepository();
            _ContactRepository.Add(_Contact);
            _ContactRepository.Save();
        }

        /// <summary>
        /// Tests the Contact repository get.
        /// </summary>
        /// <param name="_ContactId">The _ Contact identifier.</param>
        [Theory, AutoData]
        public void TestContactRepositoryGet(int  _ContactId)
        {
            var _ContactRepository = RepositoryHelper.GetContactRepository();
            var _Contact=_ContactRepository.Repository.Find(entity=>entity.ContactID==_ContactId);
            Assert.NotNull(_Contact);
        }



	}
}