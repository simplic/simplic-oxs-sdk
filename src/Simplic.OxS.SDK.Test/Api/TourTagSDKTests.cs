/*
 * Simplic.OxS.Logistics
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Simplic.OxS.SDK.Client;
using Simplic.OxS.SDK.Api;
// uncomment below to import models
//using Simplic.OxS.SDK.Model;

namespace Simplic.OxS.SDK.Test.Api
{
    /// <summary>
    ///  Class for testing TourTagSDK
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TourTagSDKTests : IDisposable
    {
        private TourTagSDK instance;

        public TourTagSDKTests()
        {
            instance = new TourTagSDK();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TourTagSDK
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TourTagSDK
            //Assert.IsType<TourTagSDK>(instance);
        }

        /// <summary>
        /// Test TourTagGet
        /// </summary>
        [Fact]
        public void TourTagGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TourTagGet();
            //Assert.IsType<List<TourTagModel>>(response);
        }

        /// <summary>
        /// Test TourTagIdDelete
        /// </summary>
        [Fact]
        public void TourTagIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.TourTagIdDelete(id);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test TourTagIdGet
        /// </summary>
        [Fact]
        public void TourTagIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.TourTagIdGet(id);
            //Assert.IsType<TourTagModel>(response);
        }

        /// <summary>
        /// Test TourTagIdPatch
        /// </summary>
        [Fact]
        public void TourTagIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //PatchTourTagRequest? patchTourTagRequest = null;
            //var response = instance.TourTagIdPatch(id, patchTourTagRequest);
            //Assert.IsType<TourTagModel>(response);
        }

        /// <summary>
        /// Test TourTagPost
        /// </summary>
        [Fact]
        public void TourTagPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTourTagRequest? createTourTagRequest = null;
            //var response = instance.TourTagPost(createTourTagRequest);
            //Assert.IsType<TourTagModel>(response);
        }
    }
}
