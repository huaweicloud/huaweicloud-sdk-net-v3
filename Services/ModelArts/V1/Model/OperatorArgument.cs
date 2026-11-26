using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OperatorArgument 
    {

        /// <summary>
        /// **参数解释**：参数键
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**：参数名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public OperatorArgTypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**：参数说明
        /// </summary>
        [JsonProperty("tips", NullValueHandling = NullValueHandling.Ignore)]
        public string Tips { get; set; }

        /// <summary>
        /// **参数解释**：参数最小值，数值型参数必填
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public float? Min { get; set; }

        /// <summary>
        /// **参数解释**：参数最大值，数值型参数必填
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public float? Max { get; set; }

        /// <summary>
        /// **参数解释**：是否为区间型数值
        /// </summary>
        [JsonProperty("between", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Between { get; set; }

        /// <summary>
        /// **参数解释**：参数选项列表
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<OperatorArgItem> Items { get; set; }

        /// <summary>
        /// **参数解释**：参数默认值，用户不可见且必填的参数必须提供默认值
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// **参数解释**：参数是否必填，默认false
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// **参数解释**：该参数界面是否展示给用户配置，默认true
        /// </summary>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        /// <summary>
        /// **参数解释**：参数前端组件类型
        /// </summary>
        [JsonProperty("arg_display_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArgDisplayType { get; set; }

        /// <summary>
        /// **参数解释**：数据集支持的任务类型，type为dataset时可用
        /// </summary>
        [JsonProperty("task_category", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskCategory { get; set; }

        /// <summary>
        /// **参数解释**：数据集来源，type为dataset时可用
        /// </summary>
        [JsonProperty("dataset_catalog", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatasetCatalog { get; set; }

        /// <summary>
        /// **参数解释**：资产类型,type为large_model时可用,多个以&#39;,&#39;分隔
        /// </summary>
        [JsonProperty("asset_types", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetTypes { get; set; }

        /// <summary>
        /// **参数解释**：资产代码,type为large_model时可用,多个以&#39;,&#39;分隔
        /// </summary>
        [JsonProperty("asset_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCodes { get; set; }

        /// <summary>
        /// **参数解释**：模型的子资产类型,type为large_model时可用
        /// </summary>
        [JsonProperty("sub_asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubAssetType { get; set; }

        /// <summary>
        /// **参数解释**：当前参数所依赖的其他参数信息列表
        /// </summary>
        [JsonProperty("depend_args", NullValueHandling = NullValueHandling.Ignore)]
        public List<DependArg> DependArgs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperatorArgument {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  tips: ").Append(Tips).Append("\n");
            sb.Append("  min: ").Append(Min).Append("\n");
            sb.Append("  max: ").Append(Max).Append("\n");
            sb.Append("  between: ").Append(Between).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  visible: ").Append(Visible).Append("\n");
            sb.Append("  argDisplayType: ").Append(ArgDisplayType).Append("\n");
            sb.Append("  taskCategory: ").Append(TaskCategory).Append("\n");
            sb.Append("  datasetCatalog: ").Append(DatasetCatalog).Append("\n");
            sb.Append("  assetTypes: ").Append(AssetTypes).Append("\n");
            sb.Append("  assetCodes: ").Append(AssetCodes).Append("\n");
            sb.Append("  subAssetType: ").Append(SubAssetType).Append("\n");
            sb.Append("  dependArgs: ").Append(DependArgs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperatorArgument);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperatorArgument input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type) return false;
            if (this.Tips != input.Tips || (this.Tips != null && !this.Tips.Equals(input.Tips))) return false;
            if (this.Min != input.Min || (this.Min != null && !this.Min.Equals(input.Min))) return false;
            if (this.Max != input.Max || (this.Max != null && !this.Max.Equals(input.Max))) return false;
            if (this.Between != input.Between || (this.Between != null && !this.Between.Equals(input.Between))) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;
            if (this.Visible != input.Visible || (this.Visible != null && !this.Visible.Equals(input.Visible))) return false;
            if (this.ArgDisplayType != input.ArgDisplayType || (this.ArgDisplayType != null && !this.ArgDisplayType.Equals(input.ArgDisplayType))) return false;
            if (this.TaskCategory != input.TaskCategory || (this.TaskCategory != null && input.TaskCategory != null && !this.TaskCategory.SequenceEqual(input.TaskCategory))) return false;
            if (this.DatasetCatalog != input.DatasetCatalog || (this.DatasetCatalog != null && input.DatasetCatalog != null && !this.DatasetCatalog.SequenceEqual(input.DatasetCatalog))) return false;
            if (this.AssetTypes != input.AssetTypes || (this.AssetTypes != null && !this.AssetTypes.Equals(input.AssetTypes))) return false;
            if (this.AssetCodes != input.AssetCodes || (this.AssetCodes != null && !this.AssetCodes.Equals(input.AssetCodes))) return false;
            if (this.SubAssetType != input.SubAssetType || (this.SubAssetType != null && !this.SubAssetType.Equals(input.SubAssetType))) return false;
            if (this.DependArgs != input.DependArgs || (this.DependArgs != null && input.DependArgs != null && !this.DependArgs.SequenceEqual(input.DependArgs))) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Tips != null) hashCode = hashCode * 59 + this.Tips.GetHashCode();
                if (this.Min != null) hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Max != null) hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Between != null) hashCode = hashCode * 59 + this.Between.GetHashCode();
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Visible != null) hashCode = hashCode * 59 + this.Visible.GetHashCode();
                if (this.ArgDisplayType != null) hashCode = hashCode * 59 + this.ArgDisplayType.GetHashCode();
                if (this.TaskCategory != null) hashCode = hashCode * 59 + this.TaskCategory.GetHashCode();
                if (this.DatasetCatalog != null) hashCode = hashCode * 59 + this.DatasetCatalog.GetHashCode();
                if (this.AssetTypes != null) hashCode = hashCode * 59 + this.AssetTypes.GetHashCode();
                if (this.AssetCodes != null) hashCode = hashCode * 59 + this.AssetCodes.GetHashCode();
                if (this.SubAssetType != null) hashCode = hashCode * 59 + this.SubAssetType.GetHashCode();
                if (this.DependArgs != null) hashCode = hashCode * 59 + this.DependArgs.GetHashCode();
                return hashCode;
            }
        }
    }
}
