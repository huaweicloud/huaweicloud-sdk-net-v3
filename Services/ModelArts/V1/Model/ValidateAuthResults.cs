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
    public class ValidateAuthResults 
    {
        /// <summary>
        /// **参数解释**：鉴权通过与否。 **取值范围**： - allow：通过。 - deny：不通过。
        /// </summary>
        /// <value>**参数解释**：鉴权通过与否。 **取值范围**： - allow：通过。 - deny：不通过。</value>
        [JsonConverter(typeof(EnumClassConverter<VerdictEnum>))]
        public class VerdictEnum
        {
            /// <summary>
            /// Enum ALLOW for value: allow
            /// </summary>
            public static readonly VerdictEnum ALLOW = new VerdictEnum("allow");

            /// <summary>
            /// Enum DENY for value: deny
            /// </summary>
            public static readonly VerdictEnum DENY = new VerdictEnum("deny");

            private static readonly Dictionary<string, VerdictEnum> StaticFields =
            new Dictionary<string, VerdictEnum>()
            {
                { "allow", ALLOW },
                { "deny", DENY },
            };

            private string _value;

            public VerdictEnum()
            {

            }

            public VerdictEnum(string value)
            {
                _value = value;
            }

            public static VerdictEnum FromValue(string value)
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

                if (this.Equals(obj as VerdictEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VerdictEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VerdictEnum a, VerdictEnum b)
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

            public static bool operator !=(VerdictEnum a, VerdictEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：细粒度权限。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释**：鉴权通过与否。 **取值范围**： - allow：通过。 - deny：不通过。
        /// </summary>
        [JsonProperty("verdict", NullValueHandling = NullValueHandling.Ignore)]
        public VerdictEnum Verdict { get; set; }
        /// <summary>
        /// **参数解释**：随机的uuid，用来定位问题使用。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("action_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionId { get; set; }

        /// <summary>
        /// **参数解释**：请求资源。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// **参数解释**：失败情况下原因。
        /// </summary>
        [JsonProperty("cause", NullValueHandling = NullValueHandling.Ignore)]
        public List<Cause> Cause { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateAuthResults {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  verdict: ").Append(Verdict).Append("\n");
            sb.Append("  actionId: ").Append(ActionId).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  cause: ").Append(Cause).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateAuthResults);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateAuthResults input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Verdict != input.Verdict) return false;
            if (this.ActionId != input.ActionId || (this.ActionId != null && !this.ActionId.Equals(input.ActionId))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.Cause != input.Cause || (this.Cause != null && input.Cause != null && !this.Cause.SequenceEqual(input.Cause))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.Verdict.GetHashCode();
                if (this.ActionId != null) hashCode = hashCode * 59 + this.ActionId.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Cause != null) hashCode = hashCode * 59 + this.Cause.GetHashCode();
                return hashCode;
            }
        }
    }
}
