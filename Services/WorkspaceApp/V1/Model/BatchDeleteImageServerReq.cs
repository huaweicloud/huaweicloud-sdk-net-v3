using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 批量删除镜像实例请求。 * 忽略不存在的镜像实例，响应正常。 * 不允许操作状态为 &#x60;创建中&#x60;、&#x60;镜像创建中&#x60;的实例，响应异常。 * 不支持资源关联发生变化后，请求删除镜像实例关联资源，任务响应异常。
    /// </summary>
    public class BatchDeleteImageServerReq 
    {

        /// <summary>
        /// 批量唯一标识请求列表，一次请求数量区间 [1, 20]
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Items { get; set; }

        /// <summary>
        /// 是否同时删除镜像实例关联资源： **⚠ 警告: 关联资源删除，对应的应用将不可用** * &#x60;true&#x60; 同时删除关联资源，包括APS服务器组，APS服务器，应用组相关资源。镜像产物相关信息保留。 * &#x60;false&#x60; 只删除镜像实例记录，保留关联资源。
        /// </summary>
        [JsonProperty("recursive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recursive { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteImageServerReq {\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  recursive: ").Append(Recursive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteImageServerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteImageServerReq input)
        {
            if (input == null) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;
            if (this.Recursive != input.Recursive || (this.Recursive != null && !this.Recursive.Equals(input.Recursive))) return false;

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
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Recursive != null) hashCode = hashCode * 59 + this.Recursive.GetHashCode();
                return hashCode;
            }
        }
    }
}
