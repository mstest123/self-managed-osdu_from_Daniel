/* 
 * self-managed-osdu
 *
 * Rest API Documentation for Self Managed OSDU
 *
 * OpenAPI spec version: 0.11.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using OsduClient.Client;
using OsduClient.Api;
using OsduClient.Model;

namespace OsduClient.Test
{
    /// <summary>
    ///  Class for testing FileServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FileServiceApiTests
    {
        private FileServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FileServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FileServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FileServiceApi
            //Assert.IsInstanceOfType(typeof(FileServiceApi), instance, "instance is a FileServiceApi");
        }

        
        /// <summary>
        /// Test DeletesMetadataRecordFileForTheGivenId
        /// </summary>
        [Test]
        public void DeletesMetadataRecordFileForTheGivenIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dataPartitionId = null;
            //string id = null;
            //instance.DeletesMetadataRecordFileForTheGivenId(dataPartitionId, id);
            
        }
        
        /// <summary>
        /// Test GetALocationInLandingZoneToUploadAFile_
        /// </summary>
        [Test]
        public void GetALocationInLandingZoneToUploadAFile_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dataPartitionId = null;
            //FileLocationRequest body = null;
            //var response = instance.GetALocationInLandingZoneToUploadAFile_(dataPartitionId, body);
            //Assert.IsInstanceOf<FileLandingZoneLocationResponse> (response, "response is FileLandingZoneLocationResponse");
        }
        
        /// <summary>
        /// Test GetTheLocationToUploadAFile
        /// </summary>
        [Test]
        public void GetTheLocationToUploadAFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dataPartitionId = null;
            //var response = instance.GetTheLocationToUploadAFile(dataPartitionId);
            //Assert.IsInstanceOf<FileSourceLocationResponse> (response, "response is FileSourceLocationResponse");
        }
        
        /// <summary>
        /// Test GetsMetadataRecordForTheGivenId
        /// </summary>
        [Test]
        public void GetsMetadataRecordForTheGivenIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dataPartitionId = null;
            //string id = null;
            //var response = instance.GetsMetadataRecordForTheGivenId(dataPartitionId, id);
            //Assert.IsInstanceOf<FileRecordVersion> (response, "response is FileRecordVersion");
        }
        
        /// <summary>
        /// Test GetsURLToDownloadTheFileAssociatedWithTheGivenId_
        /// </summary>
        [Test]
        public void GetsURLToDownloadTheFileAssociatedWithTheGivenId_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dataPartitionId = null;
            //string id = null;
            //string expiryTime = null;
            //var response = instance.GetsURLToDownloadTheFileAssociatedWithTheGivenId_(dataPartitionId, id, expiryTime);
            //Assert.IsInstanceOf<FileDownloadResponse> (response, "response is FileDownloadResponse");
        }
        
        /// <summary>
        /// Test PublishFileMetadataForAFile_
        /// </summary>
        [Test]
        public void PublishFileMetadataForAFile_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dataPartitionId = null;
            //FileMetadata body = null;
            //var response = instance.PublishFileMetadataForAFile_(dataPartitionId, body);
            //Assert.IsInstanceOf<FileMetadataResponse> (response, "response is FileMetadataResponse");
        }
        
    }

}
