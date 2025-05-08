using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// obs桶取回请求消息
    /// </summary>
    public class CreateObjectRetrievalRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_info", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo ObsInfo { get; set; }

        /// <summary>
        /// 临时恢复时间，临时恢复会产生一个标准存储副本，副本的存在时间。单位：天，默认1天。 
        /// </summary>
        [JsonProperty("days", NullValueHandling = NullValueHandling.Ignore)]
        public int? Days { get; set; }

        /// <summary>
        /// 回调地址，为空则不回调
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 自定义上下文，回调时会回调给用户，透传信息
        /// </summary>
        [JsonProperty("session_context", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionContext { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateObjectRetrievalRequestBody {\n");
            sb.Append("  obsInfo: ").Append(ObsInfo).Append("\n");
            sb.Append("  days: ").Append(Days).Append("\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  sessionContext: ").Append(SessionContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateObjectRetrievalRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateObjectRetrievalRequestBody input)
        {
            if (input == null) return false;
            if (this.ObsInfo != input.ObsInfo || (this.ObsInfo != null && !this.ObsInfo.Equals(input.ObsInfo))) return false;
            if (this.Days != input.Days || (this.Days != null && !this.Days.Equals(input.Days))) return false;
            if (this.CallbackUrl != input.CallbackUrl || (this.CallbackUrl != null && !this.CallbackUrl.Equals(input.CallbackUrl))) return false;
            if (this.SessionContext != input.SessionContext || (this.SessionContext != null && !this.SessionContext.Equals(input.SessionContext))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ObsInfo != null) hashCode = hashCode * 59 + this.ObsInfo.GetHashCode();
                if (this.Days != null) hashCode = hashCode * 59 + this.Days.GetHashCode();
                if (this.CallbackUrl != null) hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.SessionContext != null) hashCode = hashCode * 59 + this.SessionContext.GetHashCode();
                return hashCode;
            }
        }
    }
}
