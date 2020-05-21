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
    public class PostPaidServerEipBandwidth 
    {
        /// <summary>
        /// 带宽的共享类型。  共享类型枚举：PER，表示独享。WHOLE，表示共享。
        /// </summary>
        /// <value>带宽的共享类型。  共享类型枚举：PER，表示独享。WHOLE，表示共享。</value>
        [JsonConverter(typeof(EnumClassConverter<SharetypeEnum>))]
        public class SharetypeEnum
        {
            /// <summary>
            /// Enum PER for value: PER
            /// </summary>
            public static readonly SharetypeEnum PER = new SharetypeEnum("PER");

            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly SharetypeEnum WHOLE = new SharetypeEnum("WHOLE");

            public static readonly Dictionary<string, SharetypeEnum> StaticFields =
            new Dictionary<string, SharetypeEnum>()
            {
                {"PER", PER},
                {"WHOLE", WHOLE},
            };

            private string Value;

            public SharetypeEnum(string Value)
            {
                this.Value = Value;
            }

            public static SharetypeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
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

                if (this.Equals(obj as SharetypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SharetypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(SharetypeEnum a, SharetypeEnum b)
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

            public static bool operator !=(SharetypeEnum a, SharetypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：带宽大小  带宽（Mbit/s），取值范围为[1,2000]。  调整带宽时的最小单位会根据带宽范围不同存在差异。  - 小于等于300Mbit/s：默认最小单位为1Mbit/s。 - 300Mbit/s~1000Mbit/s：默认最小单位为50Mbit/s。 - 大于1000Mbit/s：默认最小单位为500Mbit/s。  &gt; 说明： &gt;  &gt; 如果share_type是PER，该参数必选项；如果share_type是WHOLE并且id有值，该参数会忽略。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 带宽的共享类型。  共享类型枚举：PER，表示独享。WHOLE，表示共享。
        /// </summary>
        [JsonProperty("sharetype", NullValueHandling = NullValueHandling.Ignore)]
        public SharetypeEnum Sharetype { get; set; }
        /// <summary>
        /// 带宽的计费类型。  - 未传该字段，表示按带宽计费。 - 字段值为空，表示按带宽计费。 - 字段值为“traffic”，表示按流量计费。 - 字段为其它值，会导致创建云服务器失败。  &gt; 说明： &gt;  &gt; 如果share_type是WHOLE并且id有值，该参数会忽略。
        /// </summary>
        [JsonProperty("chargemode", NullValueHandling = NullValueHandling.Ignore)]
        public string Chargemode { get; set; }

        /// <summary>
        /// 带宽ID，创建WHOLE类型带宽的弹性IP时可以指定之前的共享带宽创建。  取值范围：WHOLE类型的带宽ID。  &gt; 说明： &gt;  &gt; 当创建WHOLE类型的带宽时，该字段必选。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostPaidServerEipBandwidth {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  sharetype: ").Append(Sharetype).Append("\n");
            sb.Append("  chargemode: ").Append(Chargemode).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostPaidServerEipBandwidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostPaidServerEipBandwidth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Sharetype == input.Sharetype ||
                    (this.Sharetype != null &&
                    this.Sharetype.Equals(input.Sharetype))
                ) && 
                (
                    this.Chargemode == input.Chargemode ||
                    (this.Chargemode != null &&
                    this.Chargemode.Equals(input.Chargemode))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Sharetype != null)
                    hashCode = hashCode * 59 + this.Sharetype.GetHashCode();
                if (this.Chargemode != null)
                    hashCode = hashCode * 59 + this.Chargemode.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
