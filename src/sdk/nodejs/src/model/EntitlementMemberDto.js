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
    root.SelfManagedOsdu.EntitlementMemberDto = factory(root.SelfManagedOsdu.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The EntitlementMemberDto model module.
   * @module model/EntitlementMemberDto
   * @version 0.11.0
   */

  /**
   * Constructs a new <code>EntitlementMemberDto</code>.
   * @alias module:model/EntitlementMemberDto
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>EntitlementMemberDto</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/EntitlementMemberDto} obj Optional instance to populate.
   * @return {module:model/EntitlementMemberDto} The populated <code>EntitlementMemberDto</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('email'))
        obj.email = ApiClient.convertToType(data['email'], 'String');
      if (data.hasOwnProperty('role'))
        obj.role = ApiClient.convertToType(data['role'], 'String');
    }
    return obj;
  }

  /**
   * Object ID or Email Address
   * @member {String} email
   */
  exports.prototype.email = undefined;

  /**
   * Role Name
   * @member {String} role
   */
  exports.prototype.role = undefined;


  return exports;

}));
