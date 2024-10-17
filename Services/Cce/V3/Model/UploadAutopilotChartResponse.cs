using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UploadAutopilotChartResponse : SdkResponse
    {

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 模板值
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public string Values { get; set; }

        /// <summary>
        /// 模板翻译资源
        /// </summary>
        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public string Translate { get; set; }

        /// <summary>
        /// 模板介绍
        /// </summary>
        [JsonProperty("instruction", NullValueHandling = NullValueHandling.Ignore)]
        public string Instruction { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 模板的来源
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 模板的图标链接
        /// </summary>
        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        /// <summary>
        /// 是否公开模板
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public { get; set; }

        /// <summary>
        /// 模板的链接
        /// </summary>
        [JsonProperty("chart_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ChartUrl { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadAutopilotChartResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("  translate: ").Append(Translate).Append("\n");
            sb.Append("  instruction: ").Append(Instruction).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  iconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  chartUrl: ").Append(ChartUrl).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadAutopilotChartResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadAutopilotChartResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Values != input.Values || (this.Values != null && !this.Values.Equals(input.Values))) return false;
            if (this.Translate != input.Translate || (this.Translate != null && !this.Translate.Equals(input.Translate))) return false;
            if (this.Instruction != input.Instruction || (this.Instruction != null && !this.Instruction.Equals(input.Instruction))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.IconUrl != input.IconUrl || (this.IconUrl != null && !this.IconUrl.Equals(input.IconUrl))) return false;
            if (this.Public != input.Public || (this.Public != null && !this.Public.Equals(input.Public))) return false;
            if (this.ChartUrl != input.ChartUrl || (this.ChartUrl != null && !this.ChartUrl.Equals(input.ChartUrl))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;

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
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Translate != null) hashCode = hashCode * 59 + this.Translate.GetHashCode();
                if (this.Instruction != null) hashCode = hashCode * 59 + this.Instruction.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.IconUrl != null) hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.Public != null) hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.ChartUrl != null) hashCode = hashCode * 59 + this.ChartUrl.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
