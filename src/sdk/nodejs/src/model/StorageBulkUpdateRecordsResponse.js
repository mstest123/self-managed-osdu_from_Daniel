/*
 * self-managed-osdu
 * Rest API Documentation for Self Managed OSDU
 *
 * OpenAPI spec version: 0.11.0
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.21
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
    root.SelfManagedOsdu.StorageBulkUpdateRecordsResponse = factory(root.SelfManagedOsdu.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The StorageBulkUpdateRecordsResponse model module.
   * @module model/StorageBulkUpdateRecordsResponse
   * @version 0.11.0
   */

  /**
   * Constructs a new <code>StorageBulkUpdateRecordsResponse</code>.
   * Result of the record batch update request.
   * @alias module:model/StorageBulkUpdateRecordsResponse
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>StorageBulkUpdateRecordsResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/StorageBulkUpdateRecordsResponse} obj Optional instance to populate.
   * @return {module:model/StorageBulkUpdateRecordsResponse} The populated <code>StorageBulkUpdateRecordsResponse</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('recordCount'))
        obj.recordCount = ApiClient.convertToType(data['recordCount'], 'Number');
      if (data.hasOwnProperty('recordIds'))
        obj.recordIds = ApiClient.convertToType(data['recordIds'], ['String']);
      if (data.hasOwnProperty('notFoundRecordIds'))
        obj.notFoundRecordIds = ApiClient.convertToType(data['notFoundRecordIds'], ['String']);
      if (data.hasOwnProperty('unAuthorizedRecordIds'))
        obj.unAuthorizedRecordIds = ApiClient.convertToType(data['unAuthorizedRecordIds'], ['String']);
      if (data.hasOwnProperty('lockedRecordIds'))
        obj.lockedRecordIds = ApiClient.convertToType(data['lockedRecordIds'], ['String']);
    }
    return obj;
  }

  /**
   * Number of records which updated successfully.
   * @member {Number} recordCount
   */
  exports.prototype.recordCount = undefined;

  /**
   * List of successfully updated record ids.
   * @member {Array.<String>} recordIds
   */
  exports.prototype.recordIds = undefined;

  /**
   * List of record ids for whom RecordMetadata was not found
   * @member {Array.<String>} notFoundRecordIds
   */
  exports.prototype.notFoundRecordIds = undefined;

  /**
   * List of record ids for whom user does not has owner permissions
   * @member {Array.<String>} unAuthorizedRecordIds
   */
  exports.prototype.unAuthorizedRecordIds = undefined;

  /**
   * List of locked record ids
   * @member {Array.<String>} lockedRecordIds
   */
  exports.prototype.lockedRecordIds = undefined;


  return exports;

}));
