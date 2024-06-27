using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SubAppCreateParam 
    {
        /// <summary>
        /// 应用、子应用，取值：APPLICATION、SUB_APPLICATION
        /// </summary>
        /// <value>应用、子应用，取值：APPLICATION、SUB_APPLICATION</value>
        [JsonConverter(typeof(EnumClassConverter<ModelTypeEnum>))]
        public class ModelTypeEnum
        {
            /// <summary>
            /// Enum APPLICATION for value: APPLICATION
            /// </summary>
            public static readonly ModelTypeEnum APPLICATION = new ModelTypeEnum("APPLICATION");

            /// <summary>
            /// Enum SUB_APPLICATION for value: SUB_APPLICATION
            /// </summary>
            public static readonly ModelTypeEnum SUB_APPLICATION = new ModelTypeEnum("SUB_APPLICATION");

            private static readonly Dictionary<string, ModelTypeEnum> StaticFields =
            new Dictionary<string, ModelTypeEnum>()
            {
                { "APPLICATION", APPLICATION },
                { "SUB_APPLICATION", SUB_APPLICATION },
            };

            private string _value;

            public ModelTypeEnum()
            {

            }

            public ModelTypeEnum(string value)
            {
                _value = value;
            }

            public static ModelTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ModelTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModelTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModelTypeEnum a, ModelTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ModelTypeEnum a, ModelTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 子应用唯一标识
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 子应用节点显示名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 应用Id、子应用Id
        /// </summary>
        [JsonProperty("model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelId { get; set; }

        /// <summary>
        /// 应用、子应用，取值：APPLICATION、SUB_APPLICATION
        /// </summary>
        [JsonProperty("model_type", NullValueHandling = NullValueHandling.Ignore)]
        public ModelTypeEnum ModelType { get; set; }
        /// <summary>
        /// 子应用描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAppCreateParam {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  modelId: ").Append(ModelId).Append("\n");
            sb.Append("  modelType: ").Append(ModelType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubAppCreateParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubAppCreateParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
                ) && 
                (
                    this.ModelType == input.ModelType ||
                    (this.ModelType != null &&
                    this.ModelType.Equals(input.ModelType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.ModelId != null)
                    hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                if (this.ModelType != null)
                    hashCode = hashCode * 59 + this.ModelType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
