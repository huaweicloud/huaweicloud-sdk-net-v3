using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 远程鉴权配置。
    /// </summary>
    public class RemoteAuthRuleVo 
    {

        /// <summary>
        /// 可访问的鉴权服务器地址。 输入的URL必须有“http”或“https”。不能是localhost或127.0.0.1这类本地地址。 不能是CDN的加速域名。
        /// </summary>
        [JsonProperty("auth_server", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthServer { get; set; }

        /// <summary>
        /// 鉴权服务器支持的请求方法，支持GET、POST、HEAD。
        /// </summary>
        [JsonProperty("request_method", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestMethod { get; set; }

        /// <summary>
        /// all（所有文件类型）：所有文件均参与鉴权。 specific_file（指定文件类型）：指定类型的文件参与鉴权。示例：jpg|MP4。 文件类型不区分大小写，即：jpg和JPG代表同一种文件类型，多个文件类型用“|”分割。
        /// </summary>
        [JsonProperty("file_type_setting", NullValueHandling = NullValueHandling.Ignore)]
        public string FileTypeSetting { get; set; }

        /// <summary>
        /// 字符总数不能超过512,当file_type_setting等于specific_file时为必选，其余情况为空， 由大小写字母和数字构成，文件类型用竖线分隔，例如jpg|mp4，只有在必选情况下才会对该字段做校验。
        /// </summary>
        [JsonProperty("specified_file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecifiedFileType { get; set; }

        /// <summary>
        /// 设置用户请求中需要参与鉴权的参数，可选reserve_all_args（保留所有URL参数）、reserve_specific_args（保留指定URL参数）、ignore_all_args（忽略所有URL参数）。
        /// </summary>
        [JsonProperty("reserve_args_setting", NullValueHandling = NullValueHandling.Ignore)]
        public string ReserveArgsSetting { get; set; }

        /// <summary>
        /// 当reserve_args_setting等于reserve_specific_args时为必选，其余情况为空，要保留的参数，多个参数用竖线分隔：key1|key2。
        /// </summary>
        [JsonProperty("reserve_args", NullValueHandling = NullValueHandling.Ignore)]
        public string ReserveArgs { get; set; }

        /// <summary>
        /// URL鉴权参数
        /// </summary>
        [JsonProperty("add_custom_args_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomArgs> AddCustomArgsRules { get; set; }

        /// <summary>
        /// 设置用户请求中参与鉴权请求头，可选reserve_all_headers（保留所有请求头参数）、reserve_specific_headers（保留指定请求头参数）、ignore_all_headers（忽略所有请求头参数）。
        /// </summary>
        [JsonProperty("reserve_headers_setting", NullValueHandling = NullValueHandling.Ignore)]
        public string ReserveHeadersSetting { get; set; }

        /// <summary>
        /// 请求头鉴权参数
        /// </summary>
        [JsonProperty("add_custom_headers_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomArgs> AddCustomHeadersRules { get; set; }

        /// <summary>
        /// 设置鉴权成功时远程鉴权服务器返回给CDN节点的状态码。取值范围：2xx/3xx。
        /// </summary>
        [JsonProperty("auth_success_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthSuccessStatus { get; set; }

        /// <summary>
        /// 设置鉴权失败时远程鉴权服务器返回给CDN节点的状态码。取值范围：4xx/5xx。
        /// </summary>
        [JsonProperty("auth_failed_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthFailedStatus { get; set; }

        /// <summary>
        /// 设置鉴权失败时CDN节点返回给用户的状态码。取值范围：2xx/3xx/4xx/5xx。
        /// </summary>
        [JsonProperty("response_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponseStatus { get; set; }

        /// <summary>
        /// 设置鉴权超时时间，即从CDN转发鉴权请求开始，到CDN节点收到远程鉴权服务器返回的结果的时间。单位为毫秒，值为0或50~3000。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 设置鉴权超时后，CDN节点如何处理用户请求。 pass(鉴权失败放过)：鉴权超时后允许用户请求，返回对应的资源。 forbid(鉴权失败拒绝)：鉴权超时后拒绝用户请求，返回配置的响应自定义状态码给用户。
        /// </summary>
        [JsonProperty("timeout_action", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeoutAction { get; set; }

        /// <summary>
        /// 当reserve_headers_setting等于reserve_specific_headers时为必选，其余情况为空，要保留的请求头，多个请求头用竖线分隔：key1|key2。
        /// </summary>
        [JsonProperty("reserve_headers", NullValueHandling = NullValueHandling.Ignore)]
        public string ReserveHeaders { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteAuthRuleVo {\n");
            sb.Append("  authServer: ").Append(AuthServer).Append("\n");
            sb.Append("  requestMethod: ").Append(RequestMethod).Append("\n");
            sb.Append("  fileTypeSetting: ").Append(FileTypeSetting).Append("\n");
            sb.Append("  specifiedFileType: ").Append(SpecifiedFileType).Append("\n");
            sb.Append("  reserveArgsSetting: ").Append(ReserveArgsSetting).Append("\n");
            sb.Append("  reserveArgs: ").Append(ReserveArgs).Append("\n");
            sb.Append("  addCustomArgsRules: ").Append(AddCustomArgsRules).Append("\n");
            sb.Append("  reserveHeadersSetting: ").Append(ReserveHeadersSetting).Append("\n");
            sb.Append("  addCustomHeadersRules: ").Append(AddCustomHeadersRules).Append("\n");
            sb.Append("  authSuccessStatus: ").Append(AuthSuccessStatus).Append("\n");
            sb.Append("  authFailedStatus: ").Append(AuthFailedStatus).Append("\n");
            sb.Append("  responseStatus: ").Append(ResponseStatus).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  timeoutAction: ").Append(TimeoutAction).Append("\n");
            sb.Append("  reserveHeaders: ").Append(ReserveHeaders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoteAuthRuleVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoteAuthRuleVo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthServer == input.AuthServer ||
                    (this.AuthServer != null &&
                    this.AuthServer.Equals(input.AuthServer))
                ) && 
                (
                    this.RequestMethod == input.RequestMethod ||
                    (this.RequestMethod != null &&
                    this.RequestMethod.Equals(input.RequestMethod))
                ) && 
                (
                    this.FileTypeSetting == input.FileTypeSetting ||
                    (this.FileTypeSetting != null &&
                    this.FileTypeSetting.Equals(input.FileTypeSetting))
                ) && 
                (
                    this.SpecifiedFileType == input.SpecifiedFileType ||
                    (this.SpecifiedFileType != null &&
                    this.SpecifiedFileType.Equals(input.SpecifiedFileType))
                ) && 
                (
                    this.ReserveArgsSetting == input.ReserveArgsSetting ||
                    (this.ReserveArgsSetting != null &&
                    this.ReserveArgsSetting.Equals(input.ReserveArgsSetting))
                ) && 
                (
                    this.ReserveArgs == input.ReserveArgs ||
                    (this.ReserveArgs != null &&
                    this.ReserveArgs.Equals(input.ReserveArgs))
                ) && 
                (
                    this.AddCustomArgsRules == input.AddCustomArgsRules ||
                    this.AddCustomArgsRules != null &&
                    input.AddCustomArgsRules != null &&
                    this.AddCustomArgsRules.SequenceEqual(input.AddCustomArgsRules)
                ) && 
                (
                    this.ReserveHeadersSetting == input.ReserveHeadersSetting ||
                    (this.ReserveHeadersSetting != null &&
                    this.ReserveHeadersSetting.Equals(input.ReserveHeadersSetting))
                ) && 
                (
                    this.AddCustomHeadersRules == input.AddCustomHeadersRules ||
                    this.AddCustomHeadersRules != null &&
                    input.AddCustomHeadersRules != null &&
                    this.AddCustomHeadersRules.SequenceEqual(input.AddCustomHeadersRules)
                ) && 
                (
                    this.AuthSuccessStatus == input.AuthSuccessStatus ||
                    (this.AuthSuccessStatus != null &&
                    this.AuthSuccessStatus.Equals(input.AuthSuccessStatus))
                ) && 
                (
                    this.AuthFailedStatus == input.AuthFailedStatus ||
                    (this.AuthFailedStatus != null &&
                    this.AuthFailedStatus.Equals(input.AuthFailedStatus))
                ) && 
                (
                    this.ResponseStatus == input.ResponseStatus ||
                    (this.ResponseStatus != null &&
                    this.ResponseStatus.Equals(input.ResponseStatus))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.TimeoutAction == input.TimeoutAction ||
                    (this.TimeoutAction != null &&
                    this.TimeoutAction.Equals(input.TimeoutAction))
                ) && 
                (
                    this.ReserveHeaders == input.ReserveHeaders ||
                    (this.ReserveHeaders != null &&
                    this.ReserveHeaders.Equals(input.ReserveHeaders))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AuthServer != null)
                    hashCode = hashCode * 59 + this.AuthServer.GetHashCode();
                if (this.RequestMethod != null)
                    hashCode = hashCode * 59 + this.RequestMethod.GetHashCode();
                if (this.FileTypeSetting != null)
                    hashCode = hashCode * 59 + this.FileTypeSetting.GetHashCode();
                if (this.SpecifiedFileType != null)
                    hashCode = hashCode * 59 + this.SpecifiedFileType.GetHashCode();
                if (this.ReserveArgsSetting != null)
                    hashCode = hashCode * 59 + this.ReserveArgsSetting.GetHashCode();
                if (this.ReserveArgs != null)
                    hashCode = hashCode * 59 + this.ReserveArgs.GetHashCode();
                if (this.AddCustomArgsRules != null)
                    hashCode = hashCode * 59 + this.AddCustomArgsRules.GetHashCode();
                if (this.ReserveHeadersSetting != null)
                    hashCode = hashCode * 59 + this.ReserveHeadersSetting.GetHashCode();
                if (this.AddCustomHeadersRules != null)
                    hashCode = hashCode * 59 + this.AddCustomHeadersRules.GetHashCode();
                if (this.AuthSuccessStatus != null)
                    hashCode = hashCode * 59 + this.AuthSuccessStatus.GetHashCode();
                if (this.AuthFailedStatus != null)
                    hashCode = hashCode * 59 + this.AuthFailedStatus.GetHashCode();
                if (this.ResponseStatus != null)
                    hashCode = hashCode * 59 + this.ResponseStatus.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.TimeoutAction != null)
                    hashCode = hashCode * 59 + this.TimeoutAction.GetHashCode();
                if (this.ReserveHeaders != null)
                    hashCode = hashCode * 59 + this.ReserveHeaders.GetHashCode();
                return hashCode;
            }
        }
    }
}
