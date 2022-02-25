/*
 * self-managed-osdu
 * Rest API Documentation for Self Managed OSDU
 *
 * OpenAPI spec version: 0.11.0
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.22
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.SelfManagedOsdu) {
      root.SelfManagedOsdu = {};
    }
    root.SelfManagedOsdu.StorageDeleteRecordError = factory(root.SelfManagedOsdu.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The StorageDeleteRecordError model module.
   * @module model/StorageDeleteRecordError
   * @version 0.11.0
   */

  /**
   * Constructs a new <code>StorageDeleteRecordError</code>.
   * Delete Records Response Body
   * @alias module:model/StorageDeleteRecordError
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>StorageDeleteRecordError</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/StorageDeleteRecordError} obj Optional instance to populate.
   * @return {module:model/StorageDeleteRecordError} The populated <code>StorageDeleteRecordError</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('notDeletedRecordId'))
        obj.notDeletedRecordId = ApiClient.convertToType(data['notDeletedRecordId'], 'String');
      if (data.hasOwnProperty('message'))
        obj.message = ApiClient.convertToType(data['message'], 'String');
    }
    return obj;
  }

  /**
   * Record id which wasn't deleted successfully.
   * @member {String} notDeletedRecordId
   */
  exports.prototype.notDeletedRecordId = undefined;

  /**
   * Brief description of the cause why record wasn't delete
   * @member {String} message
   */
  exports.prototype.message = undefined;


  return exports;

}));