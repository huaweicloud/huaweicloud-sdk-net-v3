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
    /// 
    /// </summary>
    public class CheckTaskMetadata 
    {
        /// <summary>
        /// **参数解释：** 插件检查类型 **取值范围：** - addonStatic: 运行中插件巡检 - addonUpgrade: 插件升级前检查  
        /// </summary>
        /// <value>**参数解释：** 插件检查类型 **取值范围：** - addonStatic: 运行中插件巡检 - addonUpgrade: 插件升级前检查  </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ADDONSTATIC for value: addonStatic
            /// </summary>
            public static readonly TypeEnum ADDONSTATIC = new TypeEnum("addonStatic");

            /// <summary>
            /// Enum ADDONUPGRADE for value: addonUpgrade
            /// </summary>
            public static readonly TypeEnum ADDONUPGRADE = new TypeEnum("addonUpgrade");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "addonStatic", ADDONSTATIC },
                { "addonUpgrade", ADDONUPGRADE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 插件检查类型 **取值范围：** - addonStatic: 运行中插件巡检 - addonUpgrade: 插件升级前检查  
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释：** 插件检查任务ID，用于任务检查结果查询 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("taskID", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskID { get; set; }

        /// <summary>
        /// **参数解释：** 插件模板名称 **取值范围：** cce服务提供的插件模板，可以通过[查询AddonTemplates列表](cce_02_0321.xml)中的items[].metadata.name字段获取 
        /// </summary>
        [JsonProperty("addonTemplateName", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }

        /// <summary>
        /// **参数解释：** 插件实例名称 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("addonInstanceName", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonInstanceName { get; set; }

        /// <summary>
        /// **参数解释：** 插件实例ID **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("addonInstanceID", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonInstanceID { get; set; }

        /// <summary>
        /// **参数解释：** 插件检查任务创建时间 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("createTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeStamp { get; set; }

        /// <summary>
        /// **参数解释：** 插件检查任务超时时间，仅终态（Failed/Success）任务存在此字段 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("expireTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTimeStamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckTaskMetadata {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  taskID: ").Append(TaskID).Append("\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("  addonInstanceName: ").Append(AddonInstanceName).Append("\n");
            sb.Append("  addonInstanceID: ").Append(AddonInstanceID).Append("\n");
            sb.Append("  createTimeStamp: ").Append(CreateTimeStamp).Append("\n");
            sb.Append("  expireTimeStamp: ").Append(ExpireTimeStamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckTaskMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckTaskMetadata input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.TaskID != input.TaskID || (this.TaskID != null && !this.TaskID.Equals(input.TaskID))) return false;
            if (this.AddonTemplateName != input.AddonTemplateName || (this.AddonTemplateName != null && !this.AddonTemplateName.Equals(input.AddonTemplateName))) return false;
            if (this.AddonInstanceName != input.AddonInstanceName || (this.AddonInstanceName != null && !this.AddonInstanceName.Equals(input.AddonInstanceName))) return false;
            if (this.AddonInstanceID != input.AddonInstanceID || (this.AddonInstanceID != null && !this.AddonInstanceID.Equals(input.AddonInstanceID))) return false;
            if (this.CreateTimeStamp != input.CreateTimeStamp || (this.CreateTimeStamp != null && !this.CreateTimeStamp.Equals(input.CreateTimeStamp))) return false;
            if (this.ExpireTimeStamp != input.ExpireTimeStamp || (this.ExpireTimeStamp != null && !this.ExpireTimeStamp.Equals(input.ExpireTimeStamp))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TaskID != null) hashCode = hashCode * 59 + this.TaskID.GetHashCode();
                if (this.AddonTemplateName != null) hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                if (this.AddonInstanceName != null) hashCode = hashCode * 59 + this.AddonInstanceName.GetHashCode();
                if (this.AddonInstanceID != null) hashCode = hashCode * 59 + this.AddonInstanceID.GetHashCode();
                if (this.CreateTimeStamp != null) hashCode = hashCode * 59 + this.CreateTimeStamp.GetHashCode();
                if (this.ExpireTimeStamp != null) hashCode = hashCode * 59 + this.ExpireTimeStamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
