using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 由API Server自动维护的字段所有权记录，用于Server-Side Apply的冲突检测与字段级并发管理。
    /// </summary>
    public class ManagedFieldsEntry 
    {

        /// <summary>
        /// 管理者的名称
        /// </summary>
        [JsonProperty("manager", NullValueHandling = NullValueHandling.Ignore)]
        public string Manager { get; set; }

        /// <summary>
        /// 记录导致此条目创建的操作类型，只能是 Apply 或 Update 两种操作类型
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// 该管理者定义字段时所依据的资源 API 版本
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 此管理条目被创建或最后一次更新的时间戳
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 固定为 \&quot;FieldsV1\&quot;，标记字段结构格式
        /// </summary>
        [JsonProperty("fieldsType", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldsType { get; set; }

        /// <summary>
        /// 用于存储实际被管理的字段信息
        /// </summary>
        [JsonProperty("fieldsV1", NullValueHandling = NullValueHandling.Ignore)]
        public Object FieldsV1 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagedFieldsEntry {\n");
            sb.Append("  manager: ").Append(Manager).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  fieldsType: ").Append(FieldsType).Append("\n");
            sb.Append("  fieldsV1: ").Append(FieldsV1).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManagedFieldsEntry);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ManagedFieldsEntry input)
        {
            if (input == null) return false;
            if (this.Manager != input.Manager || (this.Manager != null && !this.Manager.Equals(input.Manager))) return false;
            if (this.Operation != input.Operation || (this.Operation != null && !this.Operation.Equals(input.Operation))) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.FieldsType != input.FieldsType || (this.FieldsType != null && !this.FieldsType.Equals(input.FieldsType))) return false;
            if (this.FieldsV1 != input.FieldsV1 || (this.FieldsV1 != null && !this.FieldsV1.Equals(input.FieldsV1))) return false;

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
                if (this.Manager != null) hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.Operation != null) hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.FieldsType != null) hashCode = hashCode * 59 + this.FieldsType.GetHashCode();
                if (this.FieldsV1 != null) hashCode = hashCode * 59 + this.FieldsV1.GetHashCode();
                return hashCode;
            }
        }
    }
}
