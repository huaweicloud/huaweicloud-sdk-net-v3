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
    /// Response Object
    /// </summary>
    public class ShowAssetByCodeAndVersionResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释**：资产状态。 **取值范围**：枚举值: - online: 上线 - offline: 下线 - waiting: 等待中
        /// </summary>
        /// <value>**参数解释**：资产状态。 **取值范围**：枚举值: - online: 上线 - offline: 下线 - waiting: 等待中</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ONLINE for value: online
            /// </summary>
            public static readonly StatusEnum ONLINE = new StatusEnum("online");

            /// <summary>
            /// Enum OFFLINE for value: offline
            /// </summary>
            public static readonly StatusEnum OFFLINE = new StatusEnum("offline");

            /// <summary>
            /// Enum WAITING for value: waiting
            /// </summary>
            public static readonly StatusEnum WAITING = new StatusEnum("waiting");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "online", ONLINE },
                { "offline", OFFLINE },
                { "waiting", WAITING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：资产id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// **参数解释**：父资产id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("parent_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentAssetId { get; set; }

        /// <summary>
        /// **参数解释**：根资产id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("root_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootAssetId { get; set; }

        /// <summary>
        /// **参数解释**：资产API版本。 **取值范围**：v1,v2。
        /// </summary>
        [JsonProperty("api_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// **参数解释**：资产名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// **参数解释**：需要加入的资产组id。 **取值范围**：0-36位字符，已存在的组id。
        /// </summary>
        [JsonProperty("asset_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetGroupId { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID，[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。]未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。 **取值范围**：1-32位字母，数字。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：资产类型。 **取值范围**：枚举值： - TEMPLATE: 模板资产 - DATASET: 数据集资产 - WORKFLOW: 工作流资产 - IMAGE: 镜像资产 - ALGORITHM：算法资产 - MODEL: 模型资产 - DATASET_TEMPLATE: 数据集模板资产
        /// </summary>
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetType { get; set; }

        /// <summary>
        /// **参数解释**：资产子类型。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("sub_asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubAssetType { get; set; }

        /// <summary>
        /// **参数解释**：资产描述。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("asset_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetDesc { get; set; }

        /// <summary>
        /// **参数解释**：资产code。 **取值范围**：1-60字符，英文字母，数字，中划线，下划线，点。
        /// </summary>
        [JsonProperty("asset_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCode { get; set; }

        /// <summary>
        /// **参数解释**：资产版本。 **取值范围**：数字或格式为x.y.z，x,y,z为数字。
        /// </summary>
        [JsonProperty("asset_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetVersion { get; set; }

        /// <summary>
        /// **参数解释**：资产tag。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<string>> Tags { get; set; }

        /// <summary>
        /// **参数解释**：资产支持的操作列表，例如监督微调:SFT,LORA微调:LORA,在线部署:ONLINE-DEPLOY,强化学习:AgenticRL。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("support_actions", NullValueHandling = NullValueHandling.Ignore)]
        public Object SupportActions { get; set; }

        /// <summary>
        /// **参数解释**：资产文件存储地址,支持OBS（对象存储服务）协议的URL和相对路径。 **取值范围**：0-1024位字符。
        /// </summary>
        [JsonProperty("asset_location", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetLocation { get; set; }

        /// <summary>
        /// **参数解释**：资产可执行操作详情配置。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssetActionRsp> Actions { get; set; }

        /// <summary>
        /// **参数解释**：资产状态。 **取值范围**：枚举值: - online: 上线 - offline: 下线 - waiting: 等待中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**：数据集用途。 **取值范围**：1-40位字符。
        /// </summary>
        [JsonProperty("dataset_usage", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetUsage { get; set; }

        /// <summary>
        /// **参数解释**：数据集存储格式，例如JSONL，TXT，MOBI，EPUB，DOCX，PDF。 **约束限制**：1-40位字符。
        /// </summary>
        [JsonProperty("dataset_file_formats", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatasetFileFormats { get; set; }

        /// <summary>
        /// **参数解释**：数据集模态划分，如音频，图像，视频。 **取值范围**：1-40位字符。
        /// </summary>
        [JsonProperty("dataset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetType { get; set; }

        /// <summary>
        /// **参数解释**：数据集模态细分值，如语义分割。 **取值范围**：1-40位字符。
        /// </summary>
        [JsonProperty("dataset_sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetSubType { get; set; }

        /// <summary>
        /// **参数解释**：数据集逻辑规范，如盘古格式。 **取值范围**：1-40位字符。
        /// </summary>
        [JsonProperty("dataset_schema_format", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetSchemaFormat { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetByCodeAndVersionResponse {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  parentAssetId: ").Append(ParentAssetId).Append("\n");
            sb.Append("  rootAssetId: ").Append(RootAssetId).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetGroupId: ").Append(AssetGroupId).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  subAssetType: ").Append(SubAssetType).Append("\n");
            sb.Append("  assetDesc: ").Append(AssetDesc).Append("\n");
            sb.Append("  assetCode: ").Append(AssetCode).Append("\n");
            sb.Append("  assetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  supportActions: ").Append(SupportActions).Append("\n");
            sb.Append("  assetLocation: ").Append(AssetLocation).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  datasetUsage: ").Append(DatasetUsage).Append("\n");
            sb.Append("  datasetFileFormats: ").Append(DatasetFileFormats).Append("\n");
            sb.Append("  datasetType: ").Append(DatasetType).Append("\n");
            sb.Append("  datasetSubType: ").Append(DatasetSubType).Append("\n");
            sb.Append("  datasetSchemaFormat: ").Append(DatasetSchemaFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetByCodeAndVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetByCodeAndVersionResponse input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.ParentAssetId != input.ParentAssetId || (this.ParentAssetId != null && !this.ParentAssetId.Equals(input.ParentAssetId))) return false;
            if (this.RootAssetId != input.RootAssetId || (this.RootAssetId != null && !this.RootAssetId.Equals(input.RootAssetId))) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetGroupId != input.AssetGroupId || (this.AssetGroupId != null && !this.AssetGroupId.Equals(input.AssetGroupId))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.AssetType != input.AssetType || (this.AssetType != null && !this.AssetType.Equals(input.AssetType))) return false;
            if (this.SubAssetType != input.SubAssetType || (this.SubAssetType != null && !this.SubAssetType.Equals(input.SubAssetType))) return false;
            if (this.AssetDesc != input.AssetDesc || (this.AssetDesc != null && !this.AssetDesc.Equals(input.AssetDesc))) return false;
            if (this.AssetCode != input.AssetCode || (this.AssetCode != null && !this.AssetCode.Equals(input.AssetCode))) return false;
            if (this.AssetVersion != input.AssetVersion || (this.AssetVersion != null && !this.AssetVersion.Equals(input.AssetVersion))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.SupportActions != input.SupportActions || (this.SupportActions != null && !this.SupportActions.Equals(input.SupportActions))) return false;
            if (this.AssetLocation != input.AssetLocation || (this.AssetLocation != null && !this.AssetLocation.Equals(input.AssetLocation))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;
            if (this.Status != input.Status) return false;
            if (this.DatasetUsage != input.DatasetUsage || (this.DatasetUsage != null && !this.DatasetUsage.Equals(input.DatasetUsage))) return false;
            if (this.DatasetFileFormats != input.DatasetFileFormats || (this.DatasetFileFormats != null && input.DatasetFileFormats != null && !this.DatasetFileFormats.SequenceEqual(input.DatasetFileFormats))) return false;
            if (this.DatasetType != input.DatasetType || (this.DatasetType != null && !this.DatasetType.Equals(input.DatasetType))) return false;
            if (this.DatasetSubType != input.DatasetSubType || (this.DatasetSubType != null && !this.DatasetSubType.Equals(input.DatasetSubType))) return false;
            if (this.DatasetSchemaFormat != input.DatasetSchemaFormat || (this.DatasetSchemaFormat != null && !this.DatasetSchemaFormat.Equals(input.DatasetSchemaFormat))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.ParentAssetId != null) hashCode = hashCode * 59 + this.ParentAssetId.GetHashCode();
                if (this.RootAssetId != null) hashCode = hashCode * 59 + this.RootAssetId.GetHashCode();
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetGroupId != null) hashCode = hashCode * 59 + this.AssetGroupId.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.AssetType != null) hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.SubAssetType != null) hashCode = hashCode * 59 + this.SubAssetType.GetHashCode();
                if (this.AssetDesc != null) hashCode = hashCode * 59 + this.AssetDesc.GetHashCode();
                if (this.AssetCode != null) hashCode = hashCode * 59 + this.AssetCode.GetHashCode();
                if (this.AssetVersion != null) hashCode = hashCode * 59 + this.AssetVersion.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.SupportActions != null) hashCode = hashCode * 59 + this.SupportActions.GetHashCode();
                if (this.AssetLocation != null) hashCode = hashCode * 59 + this.AssetLocation.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DatasetUsage != null) hashCode = hashCode * 59 + this.DatasetUsage.GetHashCode();
                if (this.DatasetFileFormats != null) hashCode = hashCode * 59 + this.DatasetFileFormats.GetHashCode();
                if (this.DatasetType != null) hashCode = hashCode * 59 + this.DatasetType.GetHashCode();
                if (this.DatasetSubType != null) hashCode = hashCode * 59 + this.DatasetSubType.GetHashCode();
                if (this.DatasetSchemaFormat != null) hashCode = hashCode * 59 + this.DatasetSchemaFormat.GetHashCode();
                return hashCode;
            }
        }
    }
}
