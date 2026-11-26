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
    /// Request Object
    /// </summary>
    public class ListAssetRequest 
    {

        /// <summary>
        /// **参数解释**：排序方向。 **约束限制**：不涉及。 **取值范围**： 枚举值： - ASC: 升序 - DESC: 降序。 **默认取值**：DESC。
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// **参数解释**：排序字段。 **约束限制**：不涉及。 **取值范围**：枚举值： - created_at: 创建时间 - updated_at: 更新时间。 **默认取值**：created_at。
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// **参数解释**：限制量，单次查询总量，必须由数字组成。 **约束限制**：不涉及。 **取值范围**：1-1000。 **默认取值**：100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**：偏移量，查询起始偏移，必须由数字组成。 **约束限制**：不涉及。 **取值范围**0-100000000。 **默认取值**：0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc)未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。
        /// </summary>
        [SDKProperty("workspace_id", IsQuery = true)]
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：资产名称,支持英文字母，数字，中划线，下划线，点，空格，中文汉字。 **约束限制**：1-128位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_name", IsQuery = true)]
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// **参数解释**: 资产类型。 **约束限制**: 枚举值: - MODEL: 模型资产 - TEMPLATE: 模板资产 - DATASET: 数据集资产 - WORKFLOW: 工作流资产 - IMAGE: 镜像资产 - ALGORITHM: 算法资产 - DATASET_TEMPLATE: 数据集模板资产 - DATA_OPERATOR: 算子镜像资产 **默认取值**: 不涉及。
        /// </summary>
        [SDKProperty("asset_type", IsQuery = true)]
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetType { get; set; }

        /// <summary>
        /// **参数解释**：资产来源。 **约束限制**：不涉及。 **取值范围**：枚举值: - Preset: 预置资产 - Publish: 用户发布资产 - Import: 用户导入资产 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_source", IsQuery = true)]
        [JsonProperty("asset_source", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetSource { get; set; }

        /// <summary>
        /// **参数解释**：用户资产来源。 **约束限制**：1-60位字符，英文字母，数字，下划线、中划线。 **取值范围**：preset_train：精调，custom_train：自定义训练，AgenticRL：强化学习。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_source_type", IsQuery = true)]
        [JsonProperty("asset_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetSourceType { get; set; }

        /// <summary>
        /// **参数解释**：资产编码。 **约束限制**：1-60字母，数字，中划线，下划线，点。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_code", IsQuery = true)]
        [JsonProperty("asset_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCode { get; set; }

        /// <summary>
        /// **参数解释**：资产版本。 **约束限制**：数字或格式为x.y.z，x,y,z为数字。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_version", IsQuery = true)]
        [JsonProperty("asset_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetVersion { get; set; }

        /// <summary>
        /// **参数解释**：资产归属的资产组id，带有该字段将在同一个资产库中所有版本进行条件筛选，否则会筛选所有资产库中的主版本。 **约束限制**：1-36字母数字，下划线，中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_group_id", IsQuery = true)]
        [JsonProperty("asset_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetGroupId { get; set; }

        /// <summary>
        /// **参数解释**：是否过滤所有版本。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：false。
        /// </summary>
        [SDKProperty("filter_all_version", IsQuery = true)]
        [JsonProperty("filter_all_version", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FilterAllVersion { get; set; }

        /// <summary>
        /// **参数解释**：资产支持的操作列表，例如SFT：监督微调，LORA微调:LORA，在线部署：ONLINE-DEPLOY，强化学习：AgenticRL。 **约束限制**：每个元素1-30位字符，英文字母，数字，下划线，中划线；最多10个元素。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("support_actions", IsQuery = true)]
        [JsonProperty("support_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportActions { get; set; }

        /// <summary>
        /// **参数解释**：检索资产时的标签，根据不同资产类型，条件可能不同。 - 需要匹配一个key对应一个value时格式为key&#x3D;value - 需要匹配一个key对应多个value中的任意一个时格式为key&#x3D;value1|value2|value3 - 需要匹配多个条件同时满足时key1&#x3D;value1,key2&#x3D;value2 - 如果需要实现模糊匹配格式为key1%&#x3D;value2（右匹配）key2&#x3D;%value2（左匹配） **约束限制**：不涉及。
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tag { get; set; }

        /// <summary>
        /// **参数解释**：过滤我创建的资产，boolean类型，取值true：查询我创建的资产，取值false：查询所有资产。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("is_mine", IsQuery = true)]
        [JsonProperty("is_mine", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMine { get; set; }

        /// <summary>
        /// **参数解释**：列表查询是否包含action。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("with_actions", IsQuery = true)]
        [JsonProperty("with_actions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithActions { get; set; }

        /// <summary>
        /// **参数解释**：资产品牌，例如DeepSeek,Qwen,Wan,GPT,Llama,GLM,ERNIE,Mistral,Kimi,Other。 **约束限制**：不涉及。 **取值范围**：0-100位。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_series", IsQuery = true)]
        [JsonProperty("asset_series", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetSeries { get; set; }

        /// <summary>
        /// **参数解释**：资产能力，为自由文本字符串列表(非严格枚举)。推荐使用以下约定值：例如TextGeneration,ImageUnderstanding,ImageGeneration,VideoGeneration,AgenticRL,Other。 **约束限制**：每个元素为1-40位字符；最多10个元素。
        /// </summary>
        [SDKProperty("asset_capabilities", IsQuery = true)]
        [JsonProperty("asset_capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetCapabilities { get; set; }

        /// <summary>
        /// **参数解释**：资产场景，如DeepThinking。 **约束限制**：不涉及。
        /// </summary>
        [SDKProperty("asset_scenes", IsQuery = true)]
        [JsonProperty("asset_scenes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetScenes { get; set; }

        /// <summary>
        /// **参数解释**：根资产id。 **约束限制**：1-36个字符，英文字母，数字，中划线，下划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("root_asset_id", IsQuery = true)]
        [JsonProperty("root_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootAssetId { get; set; }

        /// <summary>
        /// **参数解释**：父资产id。 **约束限制**：1-36个字符，英文字母，数字，中划线，下划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("parent_asset_id", IsQuery = true)]
        [JsonProperty("parent_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentAssetId { get; set; }

        /// <summary>
        /// **参数解释**：是否返回软删除的资产。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：false。
        /// </summary>
        [SDKProperty("is_deleted", IsQuery = true)]
        [JsonProperty("is_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// **参数解释**：资产id。 **约束限制**：0-100个。
        /// </summary>
        [SDKProperty("asset_ids", IsQuery = true)]
        [JsonProperty("asset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetIds { get; set; }

        /// <summary>
        /// **参数解释**：tag组合方式 **约束限制**：不涉及。 **取值范围**：and：与，or：或。 **默认取值**：and。
        /// </summary>
        [SDKProperty("tag_mode", IsQuery = true)]
        [JsonProperty("tag_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TagMode { get; set; }

        /// <summary>
        /// **参数解释**：数据集用途，例如 GENERAL：通用数据集、EVAL：评测集。 **约束限制**：1-40位字符，英文字母，数字，下划线，中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("dataset_usage", IsQuery = true)]
        [JsonProperty("dataset_usage", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetUsage { get; set; }

        /// <summary>
        /// **参数解释**：资产状态。 **约束限制**：不涉及。 **取值范围**：枚举值: - online: 上线 - offline: 下线 - waiting: 等待中 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：数据集存储格式，例如JSONL，TXT，MOBI，EPUB，DOCX，PDF。 **约束限制**：不涉及。
        /// </summary>
        [SDKProperty("dataset_file_formats", IsQuery = true)]
        [JsonProperty("dataset_file_formats", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatasetFileFormats { get; set; }

        /// <summary>
        /// **参数解释**：数据集模态划分，如音频，图像，视频。 **约束限制**：1-40位字符，英文字母，数字，下划线，中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("dataset_type", IsQuery = true)]
        [JsonProperty("dataset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetType { get; set; }

        /// <summary>
        /// **参数解释**：数据集模态细分值，如语义分割。 **约束限制**：1-40位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("dataset_sub_type", IsQuery = true)]
        [JsonProperty("dataset_sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetSubType { get; set; }

        /// <summary>
        /// **参数解释**：数据集逻辑规范，如盘古格式。 **约束限制**：1-40位字符，英文字母，数字，下划线，中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("dataset_schema_format", IsQuery = true)]
        [JsonProperty("dataset_schema_format", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetSchemaFormat { get; set; }

        /// <summary>
        /// **参数解释**：资产创建者。 **约束限制**：1-512位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("creator", IsQuery = true)]
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// **参数解释**：数据源的ID信息。 **约束限制**：1-40位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("data_source_id", IsQuery = true)]
        [JsonProperty("data_source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSourceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetRequest {\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  assetSource: ").Append(AssetSource).Append("\n");
            sb.Append("  assetSourceType: ").Append(AssetSourceType).Append("\n");
            sb.Append("  assetCode: ").Append(AssetCode).Append("\n");
            sb.Append("  assetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  assetGroupId: ").Append(AssetGroupId).Append("\n");
            sb.Append("  filterAllVersion: ").Append(FilterAllVersion).Append("\n");
            sb.Append("  supportActions: ").Append(SupportActions).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  isMine: ").Append(IsMine).Append("\n");
            sb.Append("  withActions: ").Append(WithActions).Append("\n");
            sb.Append("  assetSeries: ").Append(AssetSeries).Append("\n");
            sb.Append("  assetCapabilities: ").Append(AssetCapabilities).Append("\n");
            sb.Append("  assetScenes: ").Append(AssetScenes).Append("\n");
            sb.Append("  rootAssetId: ").Append(RootAssetId).Append("\n");
            sb.Append("  parentAssetId: ").Append(ParentAssetId).Append("\n");
            sb.Append("  isDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  assetIds: ").Append(AssetIds).Append("\n");
            sb.Append("  tagMode: ").Append(TagMode).Append("\n");
            sb.Append("  datasetUsage: ").Append(DatasetUsage).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  datasetFileFormats: ").Append(DatasetFileFormats).Append("\n");
            sb.Append("  datasetType: ").Append(DatasetType).Append("\n");
            sb.Append("  datasetSubType: ").Append(DatasetSubType).Append("\n");
            sb.Append("  datasetSchemaFormat: ").Append(DatasetSchemaFormat).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  dataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAssetRequest input)
        {
            if (input == null) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetType != input.AssetType || (this.AssetType != null && input.AssetType != null && !this.AssetType.SequenceEqual(input.AssetType))) return false;
            if (this.AssetSource != input.AssetSource || (this.AssetSource != null && !this.AssetSource.Equals(input.AssetSource))) return false;
            if (this.AssetSourceType != input.AssetSourceType || (this.AssetSourceType != null && !this.AssetSourceType.Equals(input.AssetSourceType))) return false;
            if (this.AssetCode != input.AssetCode || (this.AssetCode != null && !this.AssetCode.Equals(input.AssetCode))) return false;
            if (this.AssetVersion != input.AssetVersion || (this.AssetVersion != null && !this.AssetVersion.Equals(input.AssetVersion))) return false;
            if (this.AssetGroupId != input.AssetGroupId || (this.AssetGroupId != null && !this.AssetGroupId.Equals(input.AssetGroupId))) return false;
            if (this.FilterAllVersion != input.FilterAllVersion || (this.FilterAllVersion != null && !this.FilterAllVersion.Equals(input.FilterAllVersion))) return false;
            if (this.SupportActions != input.SupportActions || (this.SupportActions != null && input.SupportActions != null && !this.SupportActions.SequenceEqual(input.SupportActions))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && input.Tag != null && !this.Tag.SequenceEqual(input.Tag))) return false;
            if (this.IsMine != input.IsMine || (this.IsMine != null && !this.IsMine.Equals(input.IsMine))) return false;
            if (this.WithActions != input.WithActions || (this.WithActions != null && !this.WithActions.Equals(input.WithActions))) return false;
            if (this.AssetSeries != input.AssetSeries || (this.AssetSeries != null && !this.AssetSeries.Equals(input.AssetSeries))) return false;
            if (this.AssetCapabilities != input.AssetCapabilities || (this.AssetCapabilities != null && input.AssetCapabilities != null && !this.AssetCapabilities.SequenceEqual(input.AssetCapabilities))) return false;
            if (this.AssetScenes != input.AssetScenes || (this.AssetScenes != null && input.AssetScenes != null && !this.AssetScenes.SequenceEqual(input.AssetScenes))) return false;
            if (this.RootAssetId != input.RootAssetId || (this.RootAssetId != null && !this.RootAssetId.Equals(input.RootAssetId))) return false;
            if (this.ParentAssetId != input.ParentAssetId || (this.ParentAssetId != null && !this.ParentAssetId.Equals(input.ParentAssetId))) return false;
            if (this.IsDeleted != input.IsDeleted || (this.IsDeleted != null && !this.IsDeleted.Equals(input.IsDeleted))) return false;
            if (this.AssetIds != input.AssetIds || (this.AssetIds != null && input.AssetIds != null && !this.AssetIds.SequenceEqual(input.AssetIds))) return false;
            if (this.TagMode != input.TagMode || (this.TagMode != null && !this.TagMode.Equals(input.TagMode))) return false;
            if (this.DatasetUsage != input.DatasetUsage || (this.DatasetUsage != null && !this.DatasetUsage.Equals(input.DatasetUsage))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DatasetFileFormats != input.DatasetFileFormats || (this.DatasetFileFormats != null && input.DatasetFileFormats != null && !this.DatasetFileFormats.SequenceEqual(input.DatasetFileFormats))) return false;
            if (this.DatasetType != input.DatasetType || (this.DatasetType != null && !this.DatasetType.Equals(input.DatasetType))) return false;
            if (this.DatasetSubType != input.DatasetSubType || (this.DatasetSubType != null && !this.DatasetSubType.Equals(input.DatasetSubType))) return false;
            if (this.DatasetSchemaFormat != input.DatasetSchemaFormat || (this.DatasetSchemaFormat != null && !this.DatasetSchemaFormat.Equals(input.DatasetSchemaFormat))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.DataSourceId != input.DataSourceId || (this.DataSourceId != null && !this.DataSourceId.Equals(input.DataSourceId))) return false;

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
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetType != null) hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.AssetSource != null) hashCode = hashCode * 59 + this.AssetSource.GetHashCode();
                if (this.AssetSourceType != null) hashCode = hashCode * 59 + this.AssetSourceType.GetHashCode();
                if (this.AssetCode != null) hashCode = hashCode * 59 + this.AssetCode.GetHashCode();
                if (this.AssetVersion != null) hashCode = hashCode * 59 + this.AssetVersion.GetHashCode();
                if (this.AssetGroupId != null) hashCode = hashCode * 59 + this.AssetGroupId.GetHashCode();
                if (this.FilterAllVersion != null) hashCode = hashCode * 59 + this.FilterAllVersion.GetHashCode();
                if (this.SupportActions != null) hashCode = hashCode * 59 + this.SupportActions.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.IsMine != null) hashCode = hashCode * 59 + this.IsMine.GetHashCode();
                if (this.WithActions != null) hashCode = hashCode * 59 + this.WithActions.GetHashCode();
                if (this.AssetSeries != null) hashCode = hashCode * 59 + this.AssetSeries.GetHashCode();
                if (this.AssetCapabilities != null) hashCode = hashCode * 59 + this.AssetCapabilities.GetHashCode();
                if (this.AssetScenes != null) hashCode = hashCode * 59 + this.AssetScenes.GetHashCode();
                if (this.RootAssetId != null) hashCode = hashCode * 59 + this.RootAssetId.GetHashCode();
                if (this.ParentAssetId != null) hashCode = hashCode * 59 + this.ParentAssetId.GetHashCode();
                if (this.IsDeleted != null) hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.AssetIds != null) hashCode = hashCode * 59 + this.AssetIds.GetHashCode();
                if (this.TagMode != null) hashCode = hashCode * 59 + this.TagMode.GetHashCode();
                if (this.DatasetUsage != null) hashCode = hashCode * 59 + this.DatasetUsage.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DatasetFileFormats != null) hashCode = hashCode * 59 + this.DatasetFileFormats.GetHashCode();
                if (this.DatasetType != null) hashCode = hashCode * 59 + this.DatasetType.GetHashCode();
                if (this.DatasetSubType != null) hashCode = hashCode * 59 + this.DatasetSubType.GetHashCode();
                if (this.DatasetSchemaFormat != null) hashCode = hashCode * 59 + this.DatasetSchemaFormat.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.DataSourceId != null) hashCode = hashCode * 59 + this.DataSourceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
