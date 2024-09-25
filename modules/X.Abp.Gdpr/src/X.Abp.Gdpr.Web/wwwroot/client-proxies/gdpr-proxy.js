/* This file is automatically generated by ABP framework to use MVC Controllers from javascript. */


// module gdpr

(function(){

  // controller x.abp.gdpr.gdprRequest

  (function(){

    abp.utils.createNamespace(window, 'x.abp.gdpr.gdprRequest');

    x.abp.gdpr.gdprRequest.prepareUserData = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/gdpr/requests/prepare-data',
        type: 'POST',
        dataType: null
      }, ajaxParams));
    };

    x.abp.gdpr.gdprRequest.getDownloadToken = function(requestId, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/gdpr/requests/download-token' + abp.utils.buildQueryString([{ name: 'requestId', value: requestId }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.gdpr.gdprRequest.getUserData = function(requestId, token, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/gdpr/requests/data/' + requestId + '' + abp.utils.buildQueryString([{ name: 'token', value: token }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.gdpr.gdprRequest.isNewRequestAllowed = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/gdpr/requests/is-request-allowed',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.gdpr.gdprRequest.getListByUserId = function(userId, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/gdpr/requests/list' + abp.utils.buildQueryString([{ name: 'userId', value: userId }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.gdpr.gdprRequest.deleteUserData = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/gdpr/requests',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

  })();

})();

