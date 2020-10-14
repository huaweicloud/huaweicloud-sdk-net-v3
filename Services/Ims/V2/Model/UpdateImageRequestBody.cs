using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 扩展更新镜像接口请求体
    /// </summary>
    public class UpdateImageRequestBody 
    {
        /// <summary>
        /// 操作类型，目前取值为add，replace和remove。
        /// </summary>
        /// <value>操作类型，目前取值为add，replace和remove。</value>
        [JsonConverter(typeof(EnumClassConverter<OpEnum>))]
        public class OpEnum
        {
            /// <summary>
            /// Enum ADD for value: add
            /// </summary>
            public static readonly OpEnum ADD = new OpEnum("add");

            /// <summary>
            /// Enum REPLACE for value: replace
            /// </summary>
            public static readonly OpEnum REPLACE = new OpEnum("replace");

            /// <summary>
            /// Enum REMOVE for value: remove
            /// </summary>
            public static readonly OpEnum REMOVE = new OpEnum("remove");

            private static readonly Dictionary<string, OpEnum> StaticFields =
            new Dictionary<string, OpEnum>()
            {
                { "add", ADD },
                { "replace", REPLACE },
                { "remove", REMOVE },
            };

            private string Value;

            public OpEnum(string value)
            {
                Value = value;
            }

            public static OpEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as OpEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OpEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OpEnum a, OpEnum b)
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

            public static bool operator !=(OpEnum a, OpEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 操作类型，目前取值为add，replace和remove。
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public OpEnum Op { get; set; }
        /// <summary>
        /// 需要更新的属性名称，需要在属性名称前加“/”。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 需要更新属性的值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateImageRequestBody {\n");
            sb.Append("  op: ").Append(Op).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateImageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateImageRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Op == input.Op ||
                    (this.Op != null &&
                    this.Op.Equals(input.Op))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Op != null)
                    hashCode = hashCode * 59 + this.Op.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
