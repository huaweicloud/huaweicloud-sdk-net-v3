using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.SMSApi.V1.Model;

namespace HuaweiCloud.SDK.SMSApi.V1
{
    public partial class SMSApiAsyncClient : Client
    {
        public static ClientBuilder<SMSApiAsyncClient> NewBuilder()
        {
            return new ClientBuilder<SMSApiAsyncClient>("SMSApiCredentials");
        }

        
        /// <summary>
        /// 发送分批短信
        ///
        /// 发送分批短信
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSendDiffSmsResponse> BatchSendDiffSmsAsync(BatchSendDiffSmsRequest batchSendDiffSmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/sms/batchSendDiffSms/v1", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSendDiffSmsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchSendDiffSmsResponse>(response);
        }

        public AsyncInvoker<BatchSendDiffSmsResponse> BatchSendDiffSmsAsyncInvoker(BatchSendDiffSmsRequest batchSendDiffSmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/sms/batchSendDiffSms/v1", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSendDiffSmsRequest);
            return new AsyncInvoker<BatchSendDiffSmsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSendDiffSmsResponse>);
        }
        
        /// <summary>
        /// 发送短信
        ///
        /// ## 典型场景 ##
        ///  SP调用此接口发送短信。
        /// ## 接口功能 ##
        ///  该接口用于SP请求短信平台向指定用户发送短信。
        /// ## 使用说明 ##
        ///      前提条件
        ///   i.  已在短信平台获取该短信能力开放应用的app_key、app_secret。
        /// 
        ///     注意事项
        ///   a.  群发短信时，如果“to”参数携带的号码中包含除数字和+之外的其他字符，则无法向该参数携带的所有号码发送短信。如果“to”参数携带的所有号码只包含数字和+，但部分号码不符合号码规则要求，则在响应消息中会通过状态码标识发送失败的号码，不影响其他正常号码的短信发送。号码之间以英文逗号分隔，每个号码最大长度为21位，最多允许携带500个号码。
        ///   b. 本接口支持特殊AK/SK认证。
        ///   c.  X-Sdk-Date不能与发送请求时的本地时间相差太大（15分钟），否则会导致鉴权失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSendSmsResponse> BatchSendSmsAsync(BatchSendSmsRequest batchSendSmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/sms/batchSendSms/v1", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", batchSendSmsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchSendSmsResponse>(response);
        }

        public AsyncInvoker<BatchSendSmsResponse> BatchSendSmsAsyncInvoker(BatchSendSmsRequest batchSendSmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/sms/batchSendSms/v1", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", batchSendSmsRequest);
            return new AsyncInvoker<BatchSendSmsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSendSmsResponse>);
        }
        
    }
}