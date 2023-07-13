using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// os-extended-volumes:volumes_attached数据结构说明
    /// </summary>
    public class OsExtendedVolumesInfo 
    {
        /// <summary>
        /// 启动标识，“0”代表启动盘，“-1“代表非启动盘
        /// </summary>
        /// <value>启动标识，“0”代表启动盘，“-1“代表非启动盘</value>
        [JsonConverter(typeof(EnumClassConverter<BootIndexEnum>))]
        public class BootIndexEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly BootIndexEnum _0 = new BootIndexEnum("0");

            /// <summary>
            /// Enum _1 for value: -1
            /// </summary>
            public static readonly BootIndexEnum _1 = new BootIndexEnum("-1");

            private static readonly Dictionary<string, BootIndexEnum> StaticFields =
            new Dictionary<string, BootIndexEnum>()
            {
                { "0", _0 },
                { "-1", _1 },
            };

            private string _value;

            public BootIndexEnum()
            {

            }

            public BootIndexEnum(string value)
            {
                _value = value;
            }

            public static BootIndexEnum FromValue(string value)
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

                if (this.Equals(obj as BootIndexEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BootIndexEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BootIndexEnum a, BootIndexEnum b)
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

            public static bool operator !=(BootIndexEnum a, BootIndexEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 磁盘ID，格式为UUID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// 删裸金属服务器时是否一并删除该磁盘。true：是false：否
        /// </summary>
        [JsonProperty("delete_on_termination", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteOnTermination { get; set; }

        /// <summary>
        /// 启动标识，“0”代表启动盘，“-1“代表非启动盘
        /// </summary>
        [JsonProperty("bootIndex", NullValueHandling = NullValueHandling.Ignore)]
        public BootIndexEnum BootIndex { get; set; }
        /// <summary>
        /// 磁盘设备名称，例如“/dev/sdb”。
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsExtendedVolumesInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  deleteOnTermination: ").Append(DeleteOnTermination).Append("\n");
            sb.Append("  bootIndex: ").Append(BootIndex).Append("\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsExtendedVolumesInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsExtendedVolumesInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DeleteOnTermination == input.DeleteOnTermination ||
                    (this.DeleteOnTermination != null &&
                    this.DeleteOnTermination.Equals(input.DeleteOnTermination))
                ) && 
                (
                    this.BootIndex == input.BootIndex ||
                    (this.BootIndex != null &&
                    this.BootIndex.Equals(input.BootIndex))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DeleteOnTermination != null)
                    hashCode = hashCode * 59 + this.DeleteOnTermination.GetHashCode();
                if (this.BootIndex != null)
                    hashCode = hashCode * 59 + this.BootIndex.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                return hashCode;
            }
        }
    }
}
