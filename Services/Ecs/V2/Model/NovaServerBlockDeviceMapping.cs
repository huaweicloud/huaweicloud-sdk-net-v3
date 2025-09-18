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
    ///  扩展属性，指定弹性云服务器存储设备的v2接口。是存储资源的新版本接口，指定卷场景不能批创弹性云服务器。  裸金属服务器场景不支持。
    /// </summary>
    public class NovaServerBlockDeviceMapping 
    {
        /// <summary>
        /// 卷设备的源头类型，当前只支持volume、image、snapshot、blank类型。  当使用卷创建云服务器时，source_type设置为volume；当使用镜像创建云服务器时，source_type设置为image；当使用快照创建云服务器时，source_type设置为snapshot；当创建空数据卷时，source_type设置为blank。  - 说明： -  - 当卷设备的源头类型为snapshot时，且boot_index为0，则该快照对应的云硬盘必须为系统盘。
        /// </summary>
        /// <value>卷设备的源头类型，当前只支持volume、image、snapshot、blank类型。  当使用卷创建云服务器时，source_type设置为volume；当使用镜像创建云服务器时，source_type设置为image；当使用快照创建云服务器时，source_type设置为snapshot；当创建空数据卷时，source_type设置为blank。  - 说明： -  - 当卷设备的源头类型为snapshot时，且boot_index为0，则该快照对应的云硬盘必须为系统盘。</value>
        [JsonConverter(typeof(EnumClassConverter<SourceTypeEnum>))]
        public class SourceTypeEnum
        {
            /// <summary>
            /// Enum BLANK for value: blank
            /// </summary>
            public static readonly SourceTypeEnum BLANK = new SourceTypeEnum("blank");

            /// <summary>
            /// Enum SNAPSHOT for value: snapshot
            /// </summary>
            public static readonly SourceTypeEnum SNAPSHOT = new SourceTypeEnum("snapshot");

            /// <summary>
            /// Enum VOLUME for value: volume
            /// </summary>
            public static readonly SourceTypeEnum VOLUME = new SourceTypeEnum("volume");

            /// <summary>
            /// Enum IMAGE for value: image
            /// </summary>
            public static readonly SourceTypeEnum IMAGE = new SourceTypeEnum("image");

            private static readonly Dictionary<string, SourceTypeEnum> StaticFields =
            new Dictionary<string, SourceTypeEnum>()
            {
                { "blank", BLANK },
                { "snapshot", SNAPSHOT },
                { "volume", VOLUME },
                { "image", IMAGE },
            };

            private string _value;

            public SourceTypeEnum()
            {

            }

            public SourceTypeEnum(string value)
            {
                _value = value;
            }

            public static SourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceTypeEnum a, SourceTypeEnum b)
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

            public static bool operator !=(SourceTypeEnum a, SourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 卷设备的目标类型，当前仅支持volume类型。  - volume：卷。 - local：本地文件，当前不支持该类型。
        /// </summary>
        /// <value>卷设备的目标类型，当前仅支持volume类型。  - volume：卷。 - local：本地文件，当前不支持该类型。</value>
        [JsonConverter(typeof(EnumClassConverter<DestinationTypeEnum>))]
        public class DestinationTypeEnum
        {
            /// <summary>
            /// Enum VOLUME for value: volume
            /// </summary>
            public static readonly DestinationTypeEnum VOLUME = new DestinationTypeEnum("volume");

            private static readonly Dictionary<string, DestinationTypeEnum> StaticFields =
            new Dictionary<string, DestinationTypeEnum>()
            {
                { "volume", VOLUME },
            };

            private string _value;

            public DestinationTypeEnum()
            {

            }

            public DestinationTypeEnum(string value)
            {
                _value = value;
            }

            public static DestinationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DestinationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DestinationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DestinationTypeEnum a, DestinationTypeEnum b)
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

            public static bool operator !=(DestinationTypeEnum a, DestinationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 卷设备的源头类型，当前只支持volume、image、snapshot、blank类型。  当使用卷创建云服务器时，source_type设置为volume；当使用镜像创建云服务器时，source_type设置为image；当使用快照创建云服务器时，source_type设置为snapshot；当创建空数据卷时，source_type设置为blank。  - 说明： -  - 当卷设备的源头类型为snapshot时，且boot_index为0，则该快照对应的云硬盘必须为系统盘。
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public SourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// 卷设备的目标类型，当前仅支持volume类型。  - volume：卷。 - local：本地文件，当前不支持该类型。
        /// </summary>
        [JsonProperty("destination_type", NullValueHandling = NullValueHandling.Ignore)]
        public DestinationTypeEnum DestinationType { get; set; }
        /// <summary>
        /// local文件系统格式，例如：swap, ext4。  当前不支持该功能。
        /// </summary>
        [JsonProperty("guest_format", NullValueHandling = NullValueHandling.Ignore)]
        public string GuestFormat { get; set; }

        /// <summary>
        /// 卷设备名称。  &gt; 说明： &gt;  &gt; 该字段已经废弃。 &gt;  &gt; 用户指定的device_name不会生效，系统会默认生成一个device_name。
        /// </summary>
        [JsonProperty("device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceName { get; set; }

        /// <summary>
        /// 删除弹性云服务器时，是否删除卷，默认值false。  true：删除弹性云服务器时，删除卷  false：删除弹性云服务器时，不删除卷
        /// </summary>
        [JsonProperty("delete_on_termination", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// 启动标识，“0”代表启动盘，“-1“代表非启动盘。  &gt; 说明： &gt;  &gt; 当卷设备的源头类型全为volume时，boot_index的值有一个为0。
        /// </summary>
        [JsonProperty("boot_index", NullValueHandling = NullValueHandling.Ignore)]
        public string BootIndex { get; set; }

        /// <summary>
        /// 当source_type值是volume时，uuid为卷的uuid；  当source_type值是snapshot时，uuid为快照的uuid；  当source_type值是image时，uuid为镜像的uuid；
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 卷大小，整数，在source_type是image或blank，destination_type是volume的时候必选。  单位为GB。
        /// </summary>
        [JsonProperty("volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeSize { get; set; }

        /// <summary>
        /// 卷类型，在source_type是image，destination_type是volume时建议填写。  卷类型取值范围请参考 EVS 服务 [磁盘类型介绍](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaServerBlockDeviceMapping {\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  destinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  guestFormat: ").Append(GuestFormat).Append("\n");
            sb.Append("  deviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  deleteOnTermination: ").Append(DeleteOnTermination).Append("\n");
            sb.Append("  bootIndex: ").Append(BootIndex).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  volumeSize: ").Append(VolumeSize).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaServerBlockDeviceMapping);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaServerBlockDeviceMapping input)
        {
            if (input == null) return false;
            if (this.SourceType != input.SourceType) return false;
            if (this.DestinationType != input.DestinationType) return false;
            if (this.GuestFormat != input.GuestFormat || (this.GuestFormat != null && !this.GuestFormat.Equals(input.GuestFormat))) return false;
            if (this.DeviceName != input.DeviceName || (this.DeviceName != null && !this.DeviceName.Equals(input.DeviceName))) return false;
            if (this.DeleteOnTermination != input.DeleteOnTermination || (this.DeleteOnTermination != null && !this.DeleteOnTermination.Equals(input.DeleteOnTermination))) return false;
            if (this.BootIndex != input.BootIndex || (this.BootIndex != null && !this.BootIndex.Equals(input.BootIndex))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.VolumeSize != input.VolumeSize || (this.VolumeSize != null && !this.VolumeSize.Equals(input.VolumeSize))) return false;
            if (this.VolumeType != input.VolumeType || (this.VolumeType != null && !this.VolumeType.Equals(input.VolumeType))) return false;

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
                hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.GuestFormat != null) hashCode = hashCode * 59 + this.GuestFormat.GetHashCode();
                if (this.DeviceName != null) hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.DeleteOnTermination != null) hashCode = hashCode * 59 + this.DeleteOnTermination.GetHashCode();
                if (this.BootIndex != null) hashCode = hashCode * 59 + this.BootIndex.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VolumeSize != null) hashCode = hashCode * 59 + this.VolumeSize.GetHashCode();
                if (this.VolumeType != null) hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
