﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace falkonry_csharp_client.service
{
    class FalkonryService
    {
        private string host;
        private string token;
        private HttpService http;
        private void FalkonryService (string host,string token) 
        {
            this.host=host;
            this.token=token;
            this.http  = new HttpService(host, token);
        }

//FalkonryService.prototype.getPipelines = function(done) {
//  var _this = this;
//  var Pipeline = Models.Pipeline;
//  return _this.http.get('/Pipeline', function(error, response, code){
//    if(error)
//        return done(error, null, code);
//    else {
//      var pipelines = [];
//      var rawPipelines = JSON.parse(response);
//      rawPipelines.forEach(function(eachRaw){
//        pipelines.push(new Pipeline(eachRaw));
//      });
//      return done(null, pipelines, code);
//    }
//  });

//};

///**
// * To create Eventbuffer
// * @param {Eventbuffer} eventbuffer
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.createEventbuffer = function(eventbuffer, options, done) {
//  var _this = this;
//  var Eventbuffer = Models.Eventbuffer;
//  var formData = {
//    'name'           : eventbuffer.getName(),
//    'timeIdentifier' : options.timeIdentifier,
//    'timeFormat'     : (options.timeFormat || 'iso_8601')
//  };

//  if(options.data) {
//    formData['data'] = {
//      value:  (typeof options.data === 'object' ? new Buffer(JSON.stringify(options.data)) : new Buffer(options.data)),
//          options: {
//        filename: ('input-'+Utils.randomString(6) + (options.dataType === "json" ? '.json' : '.csv'))
//      }
//    };
//  }

//  return _this.http.fpost('/Eventbuffer', formData, function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      var rawEventbuffer = JSON.parse(response);
//      return done(null, new Eventbuffer(rawEventbuffer), code);
//    }
//  });
//};

///**
// * To get list of Eventbuffers
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.getEventbuffers = function(done) {
//  var _this = this;
//  var Eventbuffer = Models.Eventbuffer;
//  return _this.http.get('/Eventbuffer', function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      var eventbuffers = [];
//      var rawEventbuffers = JSON.parse(response);
//      rawEventbuffers.forEach(function(eachRaw){
//        eventbuffers.push(new Eventbuffer(eachRaw));
//      });
//      return done(null, eventbuffers, code);
//    }
//  });
//};

///**
// * To delete a Eventbuffer
// * @param {String} eventbuffers
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.deleteEventbuffer = function(eventbuffer, done) {
//  var _this = this;
//  return _this.http.delete('/Eventbuffer/'+eventbuffer, function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      return done(null, null, code);
//    }
//  });
//};

///**
// * To create Pipeline
// * @param {Pipeline} pipeline
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.createPipeline = function(pipeline, done) {
//  var _this = this;
//  var Pipeline   = Models.Pipeline;
//  var Signal     = Models.Signal;
//  var Assessment = Models.Assessment;
//  return _this.http.post('/Pipeline', pipeline.toJSON(), function(error, response, code){
//    if(error)
//        return done(error, null, code);
//    else {
//      var rawPipeline = JSON.parse(response);
//      return done(null, new Pipeline(rawPipeline), code);
//    }
//  });
//};

///**
// * To delete a Pipeline
// * @param {String} pipeline
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.deletePipeline = function(pipeline, done) {
//  var _this = this;
//  var Pipeline = Models.Pipeline;
//  return _this.http.delete('/Pipeline/'+pipeline, function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      return done(null, null, code);
//    }
//  });
//};

///**
// * To add data to a Eventbuffer
// * @param {String} eventbuffer
// * @param {Array} dataType
// * @param {Array} data
// * @param {Object} options
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.addInputData = function(eventbuffer, dataType, data, options, done) {
//  var _this = this;
//  var Eventbuffer = Models.Eventbuffer;
//  var formData = {
//    data: {
//      value:  (typeof data === 'object' ? new Buffer(JSON.stringify(data)) : new Buffer(data)),
//      options: {
//        filename: ('input-'+Utils.randomString(6)+(dataType === 'json' ? '.json' : '.csv'))
//      }
//    }
//  };
//  var path = '/Eventbuffer/' + eventbuffer;
//  if(options && options.subscription){
//    path += '?subscriptionKey=' + options.subscription;
//  }
//  return _this.http.fpost(path, formData, function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      response = JSON.parse(response);
//      return done(null, response, code);
//    }
//  });
//};

///**
// * To add data stream to a Eventbuffer
// * @param {String} eventbuffer
// * @param {String} dataType
// * @param {Stream} data
// * @param {Object} options
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.addInputStream = function(eventbuffer, dataType, data, options, done) {
//  var _this = this;
//  var Eventbuffer = Models.Eventbuffer;
//  var path = '/Eventbuffer/' + eventbuffer;
//  if(options && options.subscription){
//    path += '?subscriptionKey=' + options.subscription;
//  }
//  return _this.http.upstream(path, dataType, data, function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      response = JSON.parse(response);
//      return done(null, response, code);
//    }
//  });
//};

///**
// * To get output of a Pipeline
// * @param {String} pipeline
// * @param {Int} start
// * @param {Int} end
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.getOuptut = function(pipeline, start, end, done) {
//  var _this = this;
//  var Pipeline = Models.Pipeline;
//  var url = '/Pipeline/'+pipeline+'/output?';
//  if(typeof end === 'number') {
//    url += 'lastTime=' + end;
//    if(typeof start === 'number')
//        url += '&startTime='+start;
//  }
//  else {
//    if(typeof start === 'number')
//      url += 'startTime='+start;
//  }

//  var stream = _this.http.downstream(url);
//  return done(null, stream);
//};

///**
// * To create Subscription
// * @param {String} eventbuffer
// * @param {Subscription} subscription
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.createSubscription = function(eventbuffer, subscription, done) {
//  var _this = this;
//  var Subscription   = Models.Subscription;

//  return _this.http.post('/Eventbuffer/' + eventbuffer + '/subscription', subscription.toJSON(), function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      var rawSubscription = JSON.parse(response);
//      return done(null, new Subscription(rawSubscription), code);
//    }
//  });
//};

///**
// * To update Subscription
// * @param {String} eventbuffer
// * @param {Subscription} subscription
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.updateSubscription = function(eventbuffer, subscription, done) {
//  var _this = this;
//  var Subscription   = Models.Subscription;

//  return _this.http.put('/Eventbuffer/' + eventbuffer + '/subscription/' + subscription.getKey(), subscription.toJSON(), function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      var rawSubscription = JSON.parse(response);
//      return done(null, new Subscription(rawSubscription), code);
//    }
//  });
//};

///**
// * To delete Subscription
// * @param {String} eventbuffer
// * @param {String} subscription
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.deleteSubscription = function(eventbuffer, subscription, done) {
//  var _this = this;
//  return _this.http.delete('/Eventbuffer/' + eventbuffer + '/subscription/' + subscription, function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      return done(null, null, code);
//    }
//  });
//};

///**
// * To create Publication
// * @param {String} pipeline
// * @param {Publication} publication
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.createPublication = function(pipeline, publication, done) {
//  var _this = this;
//  var Publication   = Models.Publication;

//  return _this.http.post('/pipeline/' + pipeline + '/publication', publication.toJSON(), function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      var rawPublication = JSON.parse(response);
//      return done(null, new Publication(rawPublication), code);
//    }
//  });
//};

///**
// * To update Publication
// * @param {String} pipeline
// * @param {Publication} publication
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.updatePublication = function(pipeline, publication, done) {
//  var _this = this;
//  var Publication   = Models.Publication;

//  return _this.http.put('/pipeline/' + pipeline + '/publication/' + publication.getKey(), publication.toJSON(), function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      var rawPublication = JSON.parse(response);
//      return done(null, new Publication(rawPublication), code);
//    }
//  });
//};

///**
// * To delete Publication
// * @param {String} pipeline
// * @param {String} publication
// * @param {Function} done
// * @returns {*}
// */
//FalkonryService.prototype.deletePublication = function(pipeline, publication, done) {
//  var _this = this;
//  return _this.http.delete('/pipeline/' + pipeline + '/publication/' + publication, function(error, response, code){
//    if(error)
//      return done(error, null, code);
//    else {
//      return done(null, null, code);
//    }
//  });
//};

//module.exports = FalkonryService;
  
    }
}
