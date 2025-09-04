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
    public class TestReportCustomDetailVo 
    {

        /// <summary>
        /// 测试报告自定义模块Uri
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 测试报告自定义模块名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否显示(0:否，1:是)
        /// </summary>
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public int? Display { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 附件信息
        /// </summary>
        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachmentVo> Attachments { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [JsonProperty("updator", NullValueHandling = NullValueHandling.Ignore)]
        public string Updator { get; set; }

        /// <summary>
        /// 测试报告uri
        /// </summary>
        [JsonProperty("test_report_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TestReportUri { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("create_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// 创建人名
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 修改时间戳
        /// </summary>
        [JsonProperty("update_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// 修改人名
        /// </summary>
        [JsonProperty("updator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatorName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestReportCustomDetailVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  display: ").Append(Display).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  attachments: ").Append(Attachments).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  updator: ").Append(Updator).Append("\n");
            sb.Append("  testReportUri: ").Append(TestReportUri).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimestamp: ").Append(CreateTimestamp).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("  updatorName: ").Append(UpdatorName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestReportCustomDetailVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestReportCustomDetailVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Display != input.Display || (this.Display != null && !this.Display.Equals(input.Display))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Attachments != input.Attachments || (this.Attachments != null && input.Attachments != null && !this.Attachments.SequenceEqual(input.Attachments))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Updator != input.Updator || (this.Updator != null && !this.Updator.Equals(input.Updator))) return false;
            if (this.TestReportUri != input.TestReportUri || (this.TestReportUri != null && !this.TestReportUri.Equals(input.TestReportUri))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimestamp != input.CreateTimestamp || (this.CreateTimestamp != null && !this.CreateTimestamp.Equals(input.CreateTimestamp))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimestamp != input.UpdateTimestamp || (this.UpdateTimestamp != null && !this.UpdateTimestamp.Equals(input.UpdateTimestamp))) return false;
            if (this.UpdatorName != input.UpdatorName || (this.UpdatorName != null && !this.UpdatorName.Equals(input.UpdatorName))) return false;

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
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Display != null) hashCode = hashCode * 59 + this.Display.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Attachments != null) hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Updator != null) hashCode = hashCode * 59 + this.Updator.GetHashCode();
                if (this.TestReportUri != null) hashCode = hashCode * 59 + this.TestReportUri.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimestamp != null) hashCode = hashCode * 59 + this.CreateTimestamp.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                if (this.UpdatorName != null) hashCode = hashCode * 59 + this.UpdatorName.GetHashCode();
                return hashCode;
            }
        }
    }
}
