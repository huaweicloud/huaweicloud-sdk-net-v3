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
    public class ServerImageResponse 
    {
        /// <summary>
        /// **参数解释**：服务器镜像架构类型。 **取值范围**： - ARM - X86
        /// </summary>
        /// <value>**参数解释**：服务器镜像架构类型。 **取值范围**： - ARM - X86</value>
        [JsonConverter(typeof(EnumClassConverter<ArchEnum>))]
        public class ArchEnum
        {
            /// <summary>
            /// Enum ARM for value: ARM
            /// </summary>
            public static readonly ArchEnum ARM = new ArchEnum("ARM");

            /// <summary>
            /// Enum X86 for value: X86
            /// </summary>
            public static readonly ArchEnum X86 = new ArchEnum("X86");

            private static readonly Dictionary<string, ArchEnum> StaticFields =
            new Dictionary<string, ArchEnum>()
            {
                { "ARM", ARM },
                { "X86", X86 },
            };

            private string _value;

            public ArchEnum()
            {

            }

            public ArchEnum(string value)
            {
                _value = value;
            }

            public static ArchEnum FromValue(string value)
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

                if (this.Equals(obj as ArchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ArchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ArchEnum a, ArchEnum b)
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

            public static bool operator !=(ArchEnum a, ArchEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：服务器类型。 **取值范围**： - BMS：裸金属服务器 - ECS：弹性云服务器 - HPS：超节点服务器
        /// </summary>
        /// <value>**参数解释**：服务器类型。 **取值范围**： - BMS：裸金属服务器 - ECS：弹性云服务器 - HPS：超节点服务器</value>
        [JsonConverter(typeof(EnumClassConverter<ServerTypeEnum>))]
        public class ServerTypeEnum
        {
            /// <summary>
            /// Enum BMS for value: BMS
            /// </summary>
            public static readonly ServerTypeEnum BMS = new ServerTypeEnum("BMS");

            /// <summary>
            /// Enum ECS for value: ECS
            /// </summary>
            public static readonly ServerTypeEnum ECS = new ServerTypeEnum("ECS");

            /// <summary>
            /// Enum HPS for value: HPS
            /// </summary>
            public static readonly ServerTypeEnum HPS = new ServerTypeEnum("HPS");

            private static readonly Dictionary<string, ServerTypeEnum> StaticFields =
            new Dictionary<string, ServerTypeEnum>()
            {
                { "BMS", BMS },
                { "ECS", ECS },
                { "HPS", HPS },
            };

            private string _value;

            public ServerTypeEnum()
            {

            }

            public ServerTypeEnum(string value)
            {
                _value = value;
            }

            public static ServerTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ServerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServerTypeEnum a, ServerTypeEnum b)
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

            public static bool operator !=(ServerTypeEnum a, ServerTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：服务器镜像架构类型。 **取值范围**： - ARM - X86
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public ArchEnum Arch { get; set; }
        /// <summary>
        /// **参数解释**：服务器镜像ID。 **取值范围**：^[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// **参数解释**：服务器镜像名称。表示服务器镜像的名称。 **约束限制**：不涉及。 **取值范围**：1 - 256字符 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：服务器类型。 **取值范围**： - BMS：裸金属服务器 - ECS：弹性云服务器 - HPS：超节点服务器
        /// </summary>
        [JsonProperty("server_type", NullValueHandling = NullValueHandling.Ignore)]
        public ServerTypeEnum ServerType { get; set; }
        /// <summary>
        /// **参数解释**：服务器镜像状态。 **取值范围**： - ACTIVE - INACTIVE
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerImageResponse {\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  serverType: ").Append(ServerType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerImageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerImageResponse input)
        {
            if (input == null) return false;
            if (this.Arch != input.Arch) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ServerType != input.ServerType) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
