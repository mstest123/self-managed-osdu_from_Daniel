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
    root.SelfManagedOsdu.LegalTagRequest = factory(root.SelfManagedOsdu.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The LegalTagRequest model module.
   * @module model/LegalTagRequest
   * @version 0.11.0
   */

  /**
   * Constructs a new <code>LegalTagRequest</code>.
   * The model to retrieve multiple LegalTags in batch.
   * @alias module:model/LegalTagRequest
   * @class
   * @param names {Array.<String>} The name of all the LegalTags to retrieve.
   */
  var exports = function(names) {
    this.names = names;
  };

  /**
   * Constructs a <code>LegalTagRequest</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/LegalTagRequest} obj Optional instance to populate.
   * @return {module:model/LegalTagRequest} The populated <code>LegalTagRequest</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('names'))
        obj.names = ApiClient.convertToType(data['names'], ['String']);
    }
    return obj;
  }

  /**
   * The name of all the LegalTags to retrieve.
   * @member {Array.<String>} names
   */
  exports.prototype.names = undefined;


  return exports;

}));
