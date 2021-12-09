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
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.SelfManagedOsdu);
  }
}(this, function(expect, SelfManagedOsdu) {
  'use strict';

  var instance;

  describe('(package)', function() {
    describe('StorageMultiRecordIds', function() {
      beforeEach(function() {
        instance = new SelfManagedOsdu.StorageMultiRecordIds();
      });

      it('should create an instance of StorageMultiRecordIds', function() {
        // TODO: update the code to test StorageMultiRecordIds
        expect(instance).to.be.a(SelfManagedOsdu.StorageMultiRecordIds);
      });

      it('should have the property records (base name: "records")', function() {
        // TODO: update the code to test the property records
        expect(instance).to.have.property('records');
        // expect(instance.records).to.be(expectedValueLiteral);
      });

      it('should have the property attributes (base name: "attributes")', function() {
        // TODO: update the code to test the property attributes
        expect(instance).to.have.property('attributes');
        // expect(instance.attributes).to.be(expectedValueLiteral);
      });

    });
  });

}));
