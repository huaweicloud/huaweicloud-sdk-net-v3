using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 灾备初始化对象详情信息
    /// </summary>
    public class QueryFlowCompareDataResp 
    {

        /// <summary>
        /// 任务总数
        /// </summary>
        [JsonProperty("total_record", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalRecord { get; set; }

        /// <summary>
        /// 数据生成时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 对比结果
        /// </summary>
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public List<StructDetailVO> List { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryFlowCompareDataResp {\n");
            sb.Append("  totalRecord: ").Append(TotalRecord).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  list: ").Append(List).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryFlowCompareDataResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryFlowCompareDataResp input)
        {
            if (input == null) return false;
            if (this.TotalRecord != input.TotalRecord || (this.TotalRecord != null && !this.TotalRecord.Equals(input.TotalRecord))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.List != input.List || (this.List != null && input.List != null && !this.List.SequenceEqual(input.List))) return false;

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
                if (this.TotalRecord != null) hashCode = hashCode * 59 + this.TotalRecord.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.List != null) hashCode = hashCode * 59 + this.List.GetHashCode();
                return hashCode;
            }
        }
    }
}
