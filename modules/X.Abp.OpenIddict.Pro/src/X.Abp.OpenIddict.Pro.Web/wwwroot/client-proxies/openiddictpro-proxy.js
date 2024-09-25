/* This file is automatically generated by ABP framework to use MVC Controllers from javascript. */


// module openiddictpro

(function(){

  // controller x.abp.openIddict.application

  (function(){

    abp.utils.createNamespace(window, 'x.abp.openIddict.application');

    x.abp.openIddict.application.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/applications/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.openIddict.application.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/applications' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.openIddict.application.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/applications',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.openIddict.application.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/applications/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.openIddict.application['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/applications' + abp.utils.buildQueryString([{ name: 'id', value: id }]) + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

  })();

  // controller x.abp.openIddict.scope

  (function(){

    abp.utils.createNamespace(window, 'x.abp.openIddict.scope');

    x.abp.openIddict.scope.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/scopes/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.openIddict.scope.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/scopes' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.openIddict.scope.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/scopes',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.openIddict.scope.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/scopes/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.openIddict.scope['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/scopes' + abp.utils.buildQueryString([{ name: 'id', value: id }]) + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

    x.abp.openIddict.scope.getAllScopes = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/openiddict/scopes/all',
        type: 'GET'
      }, ajaxParams));
    };

  })();

})();

