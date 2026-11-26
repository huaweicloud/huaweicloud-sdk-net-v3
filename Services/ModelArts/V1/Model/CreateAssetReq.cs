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
    /// **参数解释**：创建模型资产请求体。
    /// </summary>
    public class CreateAssetReq 
    {
        /// <summary>
        /// **参数解释**：用户资产来源。 **约束限制**：不涉及。 **取值范围**：枚举值： - Publish：发布 - Import：导入 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：用户资产来源。 **约束限制**：不涉及。 **取值范围**：枚举值： - Publish：发布 - Import：导入 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<AssetSourceEnum>))]
        public class AssetSourceEnum
        {
            /// <summary>
            /// Enum PUBLISH for value: Publish
            /// </summary>
            public static readonly AssetSourceEnum PUBLISH = new AssetSourceEnum("Publish");

            /// <summary>
            /// Enum IMPORT for value: Import
            /// </summary>
            public static readonly AssetSourceEnum IMPORT = new AssetSourceEnum("Import");

            private static readonly Dictionary<string, AssetSourceEnum> StaticFields =
            new Dictionary<string, AssetSourceEnum>()
            {
                { "Publish", PUBLISH },
                { "Import", IMPORT },
            };

            private string _value;

            public AssetSourceEnum()
            {

            }

            public AssetSourceEnum(string value)
            {
                _value = value;
            }

            public static AssetSourceEnum FromValue(string value)
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

                if (this.Equals(obj as AssetSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssetSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssetSourceEnum a, AssetSourceEnum b)
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

            public static bool operator !=(AssetSourceEnum a, AssetSourceEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：用户资产来源类型。 **约束限制**：不涉及。 **取值范围**：枚举值： - preset_train：预训练 - custom_train：用户训练 - AgenticRL：强化学习 - DATA_CLEANING：数据清洗 - DATA_IMPORT：数据导入 - DATA_ANNOTATION：数据标注 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：用户资产来源类型。 **约束限制**：不涉及。 **取值范围**：枚举值： - preset_train：预训练 - custom_train：用户训练 - AgenticRL：强化学习 - DATA_CLEANING：数据清洗 - DATA_IMPORT：数据导入 - DATA_ANNOTATION：数据标注 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<AssetSourceTypeEnum>))]
        public class AssetSourceTypeEnum
        {
            /// <summary>
            /// Enum PRESET_TRAIN for value: preset_train
            /// </summary>
            public static readonly AssetSourceTypeEnum PRESET_TRAIN = new AssetSourceTypeEnum("preset_train");

            /// <summary>
            /// Enum CUSTOM_TRAIN for value: custom_train
            /// </summary>
            public static readonly AssetSourceTypeEnum CUSTOM_TRAIN = new AssetSourceTypeEnum("custom_train");

            /// <summary>
            /// Enum AGENTICRL for value: AgenticRL
            /// </summary>
            public static readonly AssetSourceTypeEnum AGENTICRL = new AssetSourceTypeEnum("AgenticRL");

            /// <summary>
            /// Enum DATA_CLEANING for value: DATA_CLEANING
            /// </summary>
            public static readonly AssetSourceTypeEnum DATA_CLEANING = new AssetSourceTypeEnum("DATA_CLEANING");

            /// <summary>
            /// Enum DATA_IMPORT for value: DATA_IMPORT
            /// </summary>
            public static readonly AssetSourceTypeEnum DATA_IMPORT = new AssetSourceTypeEnum("DATA_IMPORT");

            /// <summary>
            /// Enum DATA_ANNOTATION for value: DATA_ANNOTATION
            /// </summary>
            public static readonly AssetSourceTypeEnum DATA_ANNOTATION = new AssetSourceTypeEnum("DATA_ANNOTATION");

            private static readonly Dictionary<string, AssetSourceTypeEnum> StaticFields =
            new Dictionary<string, AssetSourceTypeEnum>()
            {
                { "preset_train", PRESET_TRAIN },
                { "custom_train", CUSTOM_TRAIN },
                { "AgenticRL", AGENTICRL },
                { "DATA_CLEANING", DATA_CLEANING },
                { "DATA_IMPORT", DATA_IMPORT },
                { "DATA_ANNOTATION", DATA_ANNOTATION },
            };

            private string _value;

            public AssetSourceTypeEnum()
            {

            }

            public AssetSourceTypeEnum(string value)
            {
                _value = value;
            }

            public static AssetSourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AssetSourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssetSourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssetSourceTypeEnum a, AssetSourceTypeEnum b)
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

            public static bool operator !=(AssetSourceTypeEnum a, AssetSourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：资产类型。 **约束限制**：当不传parent_asset_id时必填。 **取值范围**：枚举值: - MODEL: 模型资产 - TEMPLATE: 模板资产 - DATASET: 数据集资产 - WORKFLOW: 工作流资产 - IMAGE: 镜像资产 - ALGORITHM：算法资产 - DATASET_TEMPLATE: 数据集模板资产 - DATA_OPERATOR：算子镜像资产 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：资产类型。 **约束限制**：当不传parent_asset_id时必填。 **取值范围**：枚举值: - MODEL: 模型资产 - TEMPLATE: 模板资产 - DATASET: 数据集资产 - WORKFLOW: 工作流资产 - IMAGE: 镜像资产 - ALGORITHM：算法资产 - DATASET_TEMPLATE: 数据集模板资产 - DATA_OPERATOR：算子镜像资产 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<AssetTypeEnum>))]
        public class AssetTypeEnum
        {
            /// <summary>
            /// Enum MODEL for value: MODEL
            /// </summary>
            public static readonly AssetTypeEnum MODEL = new AssetTypeEnum("MODEL");

            /// <summary>
            /// Enum DATASET for value: DATASET
            /// </summary>
            public static readonly AssetTypeEnum DATASET = new AssetTypeEnum("DATASET");

            /// <summary>
            /// Enum TEMPLATE for value: TEMPLATE
            /// </summary>
            public static readonly AssetTypeEnum TEMPLATE = new AssetTypeEnum("TEMPLATE");

            /// <summary>
            /// Enum WORKFLOW for value: WORKFLOW
            /// </summary>
            public static readonly AssetTypeEnum WORKFLOW = new AssetTypeEnum("WORKFLOW");

            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            public static readonly AssetTypeEnum IMAGE = new AssetTypeEnum("IMAGE");

            /// <summary>
            /// Enum ALGORITHM for value: ALGORITHM
            /// </summary>
            public static readonly AssetTypeEnum ALGORITHM = new AssetTypeEnum("ALGORITHM");

            /// <summary>
            /// Enum DATASET_TEMPLATE for value: DATASET_TEMPLATE
            /// </summary>
            public static readonly AssetTypeEnum DATASET_TEMPLATE = new AssetTypeEnum("DATASET_TEMPLATE");

            /// <summary>
            /// Enum DATA_OPERATOR for value: DATA_OPERATOR
            /// </summary>
            public static readonly AssetTypeEnum DATA_OPERATOR = new AssetTypeEnum("DATA_OPERATOR");

            private static readonly Dictionary<string, AssetTypeEnum> StaticFields =
            new Dictionary<string, AssetTypeEnum>()
            {
                { "MODEL", MODEL },
                { "DATASET", DATASET },
                { "TEMPLATE", TEMPLATE },
                { "WORKFLOW", WORKFLOW },
                { "IMAGE", IMAGE },
                { "ALGORITHM", ALGORITHM },
                { "DATASET_TEMPLATE", DATASET_TEMPLATE },
                { "DATA_OPERATOR", DATA_OPERATOR },
            };

            private string _value;

            public AssetTypeEnum()
            {

            }

            public AssetTypeEnum(string value)
            {
                _value = value;
            }

            public static AssetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AssetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssetTypeEnum a, AssetTypeEnum b)
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

            public static bool operator !=(AssetTypeEnum a, AssetTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：资产状态。 **约束限制**：不涉及。 **取值范围**：枚举值: - online: 上线 - offline: 下线 - waiting: 等待中 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：资产状态。 **约束限制**：不涉及。 **取值范围**：枚举值: - online: 上线 - offline: 下线 - waiting: 等待中 **默认取值**：不涉及。</value>
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
        /// **参数解释**：导入文件来源。 **约束限制**：数据集资产导入时需要。 **取值范围**：枚举值: - OBS: 从OBS导入 - LOCAL: 从本地导入 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：导入文件来源。 **约束限制**：数据集资产导入时需要。 **取值范围**：枚举值: - OBS: 从OBS导入 - LOCAL: 从本地导入 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ImportFileSourceEnum>))]
        public class ImportFileSourceEnum
        {
            /// <summary>
            /// Enum OBS for value: OBS
            /// </summary>
            public static readonly ImportFileSourceEnum OBS = new ImportFileSourceEnum("OBS");

            /// <summary>
            /// Enum LOCAL for value: LOCAL
            /// </summary>
            public static readonly ImportFileSourceEnum LOCAL = new ImportFileSourceEnum("LOCAL");

            /// <summary>
            /// Enum AIDATALAKE for value: AIDATALAKE
            /// </summary>
            public static readonly ImportFileSourceEnum AIDATALAKE = new ImportFileSourceEnum("AIDATALAKE");

            private static readonly Dictionary<string, ImportFileSourceEnum> StaticFields =
            new Dictionary<string, ImportFileSourceEnum>()
            {
                { "OBS", OBS },
                { "LOCAL", LOCAL },
                { "AIDATALAKE", AIDATALAKE },
            };

            private string _value;

            public ImportFileSourceEnum()
            {

            }

            public ImportFileSourceEnum(string value)
            {
                _value = value;
            }

            public static ImportFileSourceEnum FromValue(string value)
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

                if (this.Equals(obj as ImportFileSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImportFileSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImportFileSourceEnum a, ImportFileSourceEnum b)
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

            public static bool operator !=(ImportFileSourceEnum a, ImportFileSourceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：父资产id。 **约束限制**：1-36位字符，英文字母，数字，中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("parent_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentAssetId { get; set; }

        /// <summary>
        /// **参数解释**：资产API版本，固定v2。 **约束限制**：固定v2。 **取值范围**：v2。 **默认取值**：v2。
        /// </summary>
        [JsonProperty("api_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// **参数解释**：资产名称。 **约束限制**：1-128位字符，只包含中文、字母、数字、中划线、下划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// **参数解释**：用户资产来源。 **约束限制**：不涉及。 **取值范围**：枚举值： - Publish：发布 - Import：导入 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_source", NullValueHandling = NullValueHandling.Ignore)]
        public AssetSourceEnum AssetSource { get; set; }
        /// <summary>
        /// **参数解释**：用户资产来源类型。 **约束限制**：不涉及。 **取值范围**：枚举值： - preset_train：预训练 - custom_train：用户训练 - AgenticRL：强化学习 - DATA_CLEANING：数据清洗 - DATA_IMPORT：数据导入 - DATA_ANNOTATION：数据标注 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssetSourceTypeEnum AssetSourceType { get; set; }
        /// <summary>
        /// **参数解释**：资产code。 **约束限制**：1-60字符，英文字母，数字，中划线，下划线，点。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCode { get; set; }

        /// <summary>
        /// **参数解释**：资产描述。 **约束限制**：0-512位字符，不能包含英文尖括号（即 &lt; 或 &gt;）。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetDesc { get; set; }

        /// <summary>
        /// **参数解释**：资产组描述。 **约束限制**：0-512位字符，不能包含英文尖括号（即 &lt; 或 &gt;）。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_group_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetGroupDesc { get; set; }

        /// <summary>
        /// **参数解释**：资产版本号。 **约束限制**：0-99数字字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetVersion { get; set; }

        /// <summary>
        /// **参数解释**：资产支持的操作列表，例如监督微调:SFT,LORA微调:LORA,在线部署:ONLINE-DEPLOY,强化学习:AgenticRL。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("support_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportActions { get; set; }

        /// <summary>
        /// **参数解释**：资产文件存储地址,支持OBS（对象存储服务）协议的URL和相对路径。 **约束限制**：0-1024位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_location", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetLocation { get; set; }

        /// <summary>
        /// **参数解释**：资产类型。 **约束限制**：当不传parent_asset_id时必填。 **取值范围**：枚举值: - MODEL: 模型资产 - TEMPLATE: 模板资产 - DATASET: 数据集资产 - WORKFLOW: 工作流资产 - IMAGE: 镜像资产 - ALGORITHM：算法资产 - DATASET_TEMPLATE: 数据集模板资产 - DATA_OPERATOR：算子镜像资产 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssetTypeEnum AssetType { get; set; }
        /// <summary>
        /// **参数解释**：需要加入的资产组id。 **约束限制**：1-36位字符，已存在的组id。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetGroupId { get; set; }

        /// <summary>
        /// **参数解释**：资产品牌，例如DeepSeek,Qwen,Wan,GPT,Llama,GLM,ERNIE,Mistral,Kimi,Other。 **约束限制**：1-40位字符，仅支持英文字母、数字、下划线和中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_series", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetSeries { get; set; }

        /// <summary>
        /// **参数解释**：资产能力，为自由文本字符串列表(非严格枚举)。推荐使用以下约定值：例如TextGeneration,ImageUnderstanding,ImageGeneration,VideoGeneration,Other。 **约束限制**：每个元素1-40位字符，仅支持英文字母、数字、下划线和中划线；最多10个元素。
        /// </summary>
        [JsonProperty("asset_capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetCapabilities { get; set; }

        /// <summary>
        /// **参数解释**：资产可执行操作详情配置。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssetActionReq> Actions { get; set; }

        /// <summary>
        /// **参数解释**：模型来源于哪个操作。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("source_operation", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceOperation { get; set; }

        /// <summary>
        /// **参数解释**：模型来源作业的名称。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("source_job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceJobName { get; set; }

        /// <summary>
        /// **参数解释**：模型来源作业的ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("source_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceJobId { get; set; }

        /// <summary>
        /// **参数解释**：资产状态。 **约束限制**：不涉及。 **取值范围**：枚举值: - online: 上线 - offline: 下线 - waiting: 等待中 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**：数据集用途。 **约束限制**：1-40位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("dataset_usage", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetUsage { get; set; }

        /// <summary>
        /// **参数解释**：数据集存储格式，例如JSONL，TXT，MOBI，EPUB，DOCX，PDF。 **约束限制**：0-40位字符。
        /// </summary>
        [JsonProperty("dataset_file_formats", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatasetFileFormats { get; set; }

        /// <summary>
        /// **参数解释**：数据集模态划分，如音频，图像，视频。 **约束限制**：1-40位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("dataset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetType { get; set; }

        /// <summary>
        /// **参数解释**：数据集模态细分值，如语义分割。 **约束限制**：1-40位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("dataset_sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetSubType { get; set; }

        /// <summary>
        /// **参数解释**：数据集逻辑规范，如盘古格式。 **约束限制**：1-40位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("dataset_schema_format", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetSchemaFormat { get; set; }

        /// <summary>
        /// **参数解释**：导入文件来源。 **约束限制**：数据集资产导入时需要。 **取值范围**：枚举值: - OBS: 从OBS导入 - LOCAL: 从本地导入 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("import_file_source", NullValueHandling = NullValueHandling.Ignore)]
        public ImportFileSourceEnum ImportFileSource { get; set; }
        /// <summary>
        /// **参数解释**：数据集资产数据源的ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("data_source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSourceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAssetReq {\n");
            sb.Append("  parentAssetId: ").Append(ParentAssetId).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetSource: ").Append(AssetSource).Append("\n");
            sb.Append("  assetSourceType: ").Append(AssetSourceType).Append("\n");
            sb.Append("  assetCode: ").Append(AssetCode).Append("\n");
            sb.Append("  assetDesc: ").Append(AssetDesc).Append("\n");
            sb.Append("  assetGroupDesc: ").Append(AssetGroupDesc).Append("\n");
            sb.Append("  assetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  supportActions: ").Append(SupportActions).Append("\n");
            sb.Append("  assetLocation: ").Append(AssetLocation).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  assetGroupId: ").Append(AssetGroupId).Append("\n");
            sb.Append("  assetSeries: ").Append(AssetSeries).Append("\n");
            sb.Append("  assetCapabilities: ").Append(AssetCapabilities).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  sourceOperation: ").Append(SourceOperation).Append("\n");
            sb.Append("  sourceJobName: ").Append(SourceJobName).Append("\n");
            sb.Append("  sourceJobId: ").Append(SourceJobId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  datasetUsage: ").Append(DatasetUsage).Append("\n");
            sb.Append("  datasetFileFormats: ").Append(DatasetFileFormats).Append("\n");
            sb.Append("  datasetType: ").Append(DatasetType).Append("\n");
            sb.Append("  datasetSubType: ").Append(DatasetSubType).Append("\n");
            sb.Append("  datasetSchemaFormat: ").Append(DatasetSchemaFormat).Append("\n");
            sb.Append("  importFileSource: ").Append(ImportFileSource).Append("\n");
            sb.Append("  dataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAssetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAssetReq input)
        {
            if (input == null) return false;
            if (this.ParentAssetId != input.ParentAssetId || (this.ParentAssetId != null && !this.ParentAssetId.Equals(input.ParentAssetId))) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetSource != input.AssetSource) return false;
            if (this.AssetSourceType != input.AssetSourceType) return false;
            if (this.AssetCode != input.AssetCode || (this.AssetCode != null && !this.AssetCode.Equals(input.AssetCode))) return false;
            if (this.AssetDesc != input.AssetDesc || (this.AssetDesc != null && !this.AssetDesc.Equals(input.AssetDesc))) return false;
            if (this.AssetGroupDesc != input.AssetGroupDesc || (this.AssetGroupDesc != null && !this.AssetGroupDesc.Equals(input.AssetGroupDesc))) return false;
            if (this.AssetVersion != input.AssetVersion || (this.AssetVersion != null && !this.AssetVersion.Equals(input.AssetVersion))) return false;
            if (this.SupportActions != input.SupportActions || (this.SupportActions != null && input.SupportActions != null && !this.SupportActions.SequenceEqual(input.SupportActions))) return false;
            if (this.AssetLocation != input.AssetLocation || (this.AssetLocation != null && !this.AssetLocation.Equals(input.AssetLocation))) return false;
            if (this.AssetType != input.AssetType) return false;
            if (this.AssetGroupId != input.AssetGroupId || (this.AssetGroupId != null && !this.AssetGroupId.Equals(input.AssetGroupId))) return false;
            if (this.AssetSeries != input.AssetSeries || (this.AssetSeries != null && !this.AssetSeries.Equals(input.AssetSeries))) return false;
            if (this.AssetCapabilities != input.AssetCapabilities || (this.AssetCapabilities != null && input.AssetCapabilities != null && !this.AssetCapabilities.SequenceEqual(input.AssetCapabilities))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;
            if (this.SourceOperation != input.SourceOperation || (this.SourceOperation != null && !this.SourceOperation.Equals(input.SourceOperation))) return false;
            if (this.SourceJobName != input.SourceJobName || (this.SourceJobName != null && !this.SourceJobName.Equals(input.SourceJobName))) return false;
            if (this.SourceJobId != input.SourceJobId || (this.SourceJobId != null && !this.SourceJobId.Equals(input.SourceJobId))) return false;
            if (this.Status != input.Status) return false;
            if (this.DatasetUsage != input.DatasetUsage || (this.DatasetUsage != null && !this.DatasetUsage.Equals(input.DatasetUsage))) return false;
            if (this.DatasetFileFormats != input.DatasetFileFormats || (this.DatasetFileFormats != null && input.DatasetFileFormats != null && !this.DatasetFileFormats.SequenceEqual(input.DatasetFileFormats))) return false;
            if (this.DatasetType != input.DatasetType || (this.DatasetType != null && !this.DatasetType.Equals(input.DatasetType))) return false;
            if (this.DatasetSubType != input.DatasetSubType || (this.DatasetSubType != null && !this.DatasetSubType.Equals(input.DatasetSubType))) return false;
            if (this.DatasetSchemaFormat != input.DatasetSchemaFormat || (this.DatasetSchemaFormat != null && !this.DatasetSchemaFormat.Equals(input.DatasetSchemaFormat))) return false;
            if (this.ImportFileSource != input.ImportFileSource) return false;
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
                if (this.ParentAssetId != null) hashCode = hashCode * 59 + this.ParentAssetId.GetHashCode();
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                hashCode = hashCode * 59 + this.AssetSource.GetHashCode();
                hashCode = hashCode * 59 + this.AssetSourceType.GetHashCode();
                if (this.AssetCode != null) hashCode = hashCode * 59 + this.AssetCode.GetHashCode();
                if (this.AssetDesc != null) hashCode = hashCode * 59 + this.AssetDesc.GetHashCode();
                if (this.AssetGroupDesc != null) hashCode = hashCode * 59 + this.AssetGroupDesc.GetHashCode();
                if (this.AssetVersion != null) hashCode = hashCode * 59 + this.AssetVersion.GetHashCode();
                if (this.SupportActions != null) hashCode = hashCode * 59 + this.SupportActions.GetHashCode();
                if (this.AssetLocation != null) hashCode = hashCode * 59 + this.AssetLocation.GetHashCode();
                hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.AssetGroupId != null) hashCode = hashCode * 59 + this.AssetGroupId.GetHashCode();
                if (this.AssetSeries != null) hashCode = hashCode * 59 + this.AssetSeries.GetHashCode();
                if (this.AssetCapabilities != null) hashCode = hashCode * 59 + this.AssetCapabilities.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.SourceOperation != null) hashCode = hashCode * 59 + this.SourceOperation.GetHashCode();
                if (this.SourceJobName != null) hashCode = hashCode * 59 + this.SourceJobName.GetHashCode();
                if (this.SourceJobId != null) hashCode = hashCode * 59 + this.SourceJobId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DatasetUsage != null) hashCode = hashCode * 59 + this.DatasetUsage.GetHashCode();
                if (this.DatasetFileFormats != null) hashCode = hashCode * 59 + this.DatasetFileFormats.GetHashCode();
                if (this.DatasetType != null) hashCode = hashCode * 59 + this.DatasetType.GetHashCode();
                if (this.DatasetSubType != null) hashCode = hashCode * 59 + this.DatasetSubType.GetHashCode();
                if (this.DatasetSchemaFormat != null) hashCode = hashCode * 59 + this.DatasetSchemaFormat.GetHashCode();
                hashCode = hashCode * 59 + this.ImportFileSource.GetHashCode();
                if (this.DataSourceId != null) hashCode = hashCode * 59 + this.DataSourceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
