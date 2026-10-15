using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 回放库和镜像库里面SQL执行结果不一致详情。
    /// </summary>
    public class ReplayCompareResultResp 
    {

        /// <summary>
        /// SQL模板
        /// </summary>
        [JsonProperty("sql_template", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlTemplate { get; set; }

        /// <summary>
        /// SQL模板MD5哈希值
        /// </summary>
        [JsonProperty("sql_template_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlTemplateMd5 { get; set; }

        /// <summary>
        /// SQL参数
        /// </summary>
        [JsonProperty("sql_params", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlParams { get; set; }

        /// <summary>
        /// 目标库内容
        /// </summary>
        [JsonProperty("target_content", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetContent { get; set; }

        /// <summary>
        /// 镜像库内容
        /// </summary>
        [JsonProperty("mirror_content", NullValueHandling = NullValueHandling.Ignore)]
        public string MirrorContent { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplayCompareResultResp {\n");
            sb.Append("  sqlTemplate: ").Append(SqlTemplate).Append("\n");
            sb.Append("  sqlTemplateMd5: ").Append(SqlTemplateMd5).Append("\n");
            sb.Append("  sqlParams: ").Append(SqlParams).Append("\n");
            sb.Append("  targetContent: ").Append(TargetContent).Append("\n");
            sb.Append("  mirrorContent: ").Append(MirrorContent).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplayCompareResultResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplayCompareResultResp input)
        {
            if (input == null) return false;
            if (this.SqlTemplate != input.SqlTemplate || (this.SqlTemplate != null && !this.SqlTemplate.Equals(input.SqlTemplate))) return false;
            if (this.SqlTemplateMd5 != input.SqlTemplateMd5 || (this.SqlTemplateMd5 != null && !this.SqlTemplateMd5.Equals(input.SqlTemplateMd5))) return false;
            if (this.SqlParams != input.SqlParams || (this.SqlParams != null && !this.SqlParams.Equals(input.SqlParams))) return false;
            if (this.TargetContent != input.TargetContent || (this.TargetContent != null && !this.TargetContent.Equals(input.TargetContent))) return false;
            if (this.MirrorContent != input.MirrorContent || (this.MirrorContent != null && !this.MirrorContent.Equals(input.MirrorContent))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.SqlTemplate != null) hashCode = hashCode * 59 + this.SqlTemplate.GetHashCode();
                if (this.SqlTemplateMd5 != null) hashCode = hashCode * 59 + this.SqlTemplateMd5.GetHashCode();
                if (this.SqlParams != null) hashCode = hashCode * 59 + this.SqlParams.GetHashCode();
                if (this.TargetContent != null) hashCode = hashCode * 59 + this.TargetContent.GetHashCode();
                if (this.MirrorContent != null) hashCode = hashCode * 59 + this.MirrorContent.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
