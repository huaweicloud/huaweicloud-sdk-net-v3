using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PostPaidServerEipExtendParam 
    {
        /// <summary>
        /// 公网IP的计费模式。  取值范围：  - prePaid-预付费，即包年包月； - postPaid-后付费，即按需付费；  &gt; 说明： &gt;  &gt; 如果bandwidth对象中share_type是WHOLE且id有值，弹性IP只能创建为按需付费的，故该参数传参“prePaid”无效。
        /// </summary>
        /// <value>公网IP的计费模式。  取值范围：  - prePaid-预付费，即包年包月； - postPaid-后付费，即按需付费；  &gt; 说明： &gt;  &gt; 如果bandwidth对象中share_type是WHOLE且id有值，弹性IP只能创建为按需付费的，故该参数传参“prePaid”无效。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum PREPAID for value: prePaid
            /// </summary>
            public static readonly ChargingModeEnum PREPAID = new ChargingModeEnum("prePaid");

            /// <summary>
            /// Enum POSTPAID for value: postPaid
            /// </summary>
            public static readonly ChargingModeEnum POSTPAID = new ChargingModeEnum("postPaid");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "prePaid", PREPAID },
                { "postPaid", POSTPAID },
            };

            private string Value;

            public ChargingModeEnum(string value)
            {
                Value = value;
            }

            public static ChargingModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ChargingModeEnum a, ChargingModeEnum b)
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

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 公网IP的计费模式。  取值范围：  - prePaid-预付费，即包年包月； - postPaid-后付费，即按需付费；  &gt; 说明： &gt;  &gt; 如果bandwidth对象中share_type是WHOLE且id有值，弹性IP只能创建为按需付费的，故该参数传参“prePaid”无效。
        /// </summary>
        [JsonProperty("chargingMode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostPaidServerEipExtendParam {\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostPaidServerEipExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostPaidServerEipExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
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
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
