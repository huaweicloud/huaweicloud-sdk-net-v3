using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowUserAccessStagesResponse : SdkResponse
    {
        /// <summary>
        /// 接入阶段 | APP - 应用 DESKTOP - 桌面。
        /// </summary>
        /// <value>接入阶段 | APP - 应用 DESKTOP - 桌面。</value>
        [JsonConverter(typeof(EnumClassConverter<BizTypeEnum>))]
        public class BizTypeEnum
        {
            /// <summary>
            /// Enum APP for value: APP
            /// </summary>
            public static readonly BizTypeEnum APP = new BizTypeEnum("APP");

            /// <summary>
            /// Enum DESKTOP for value: DESKTOP
            /// </summary>
            public static readonly BizTypeEnum DESKTOP = new BizTypeEnum("DESKTOP");

            private static readonly Dictionary<string, BizTypeEnum> StaticFields =
            new Dictionary<string, BizTypeEnum>()
            {
                { "APP", APP },
                { "DESKTOP", DESKTOP },
            };

            private string _value;

            public BizTypeEnum()
            {

            }

            public BizTypeEnum(string value)
            {
                _value = value;
            }

            public static BizTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BizTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BizTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BizTypeEnum a, BizTypeEnum b)
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

            public static bool operator !=(BizTypeEnum a, BizTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 接入阶段 | APP - 应用 DESKTOP - 桌面。
        /// </summary>
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public BizTypeEnum BizType { get; set; }
        /// <summary>
        /// 接入各阶段详情。
        /// </summary>
        [JsonProperty("stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserAccessStage> Stages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserAccessStagesResponse {\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  bizType: ").Append(BizType).Append("\n");
            sb.Append("  stages: ").Append(Stages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserAccessStagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserAccessStagesResponse input)
        {
            if (input == null) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.BizType != input.BizType) return false;
            if (this.Stages != input.Stages || (this.Stages != null && input.Stages != null && !this.Stages.SequenceEqual(input.Stages))) return false;

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
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                hashCode = hashCode * 59 + this.BizType.GetHashCode();
                if (this.Stages != null) hashCode = hashCode * 59 + this.Stages.GetHashCode();
                return hashCode;
            }
        }
    }
}
