using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class UpdateTestCaseListVo 
    {

        /// <summary>
        /// CTS需要返回资源id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// CTS需要返回资源name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 成功批量更新用例的id列表
        /// </summary>
        [JsonProperty("success_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SuccessList { get; set; }

        /// <summary>
        /// 没有批量更新用例的id列表
        /// </summary>
        [JsonProperty("failed_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FailedList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTestCaseListVo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  successList: ").Append(SuccessList).Append("\n");
            sb.Append("  failedList: ").Append(FailedList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTestCaseListVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTestCaseListVo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SuccessList != input.SuccessList || (this.SuccessList != null && input.SuccessList != null && !this.SuccessList.SequenceEqual(input.SuccessList))) return false;
            if (this.FailedList != input.FailedList || (this.FailedList != null && input.FailedList != null && !this.FailedList.SequenceEqual(input.FailedList))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SuccessList != null) hashCode = hashCode * 59 + this.SuccessList.GetHashCode();
                if (this.FailedList != null) hashCode = hashCode * 59 + this.FailedList.GetHashCode();
                return hashCode;
            }
        }
    }
}
