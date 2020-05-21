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
    ///  弹性云服务器信息
    /// </summary>
    public class NovaCreateServersOption 
    {
        /// <summary>
        /// diskConfig的方式，取值为AUTO、MANUAL。  - MANUAL，镜像空间不会扩展。 - AUTO，系统盘镜像空间会自动扩展为与flavor大小一致。  当前不支持该功能。
        /// </summary>
        /// <value>diskConfig的方式，取值为AUTO、MANUAL。  - MANUAL，镜像空间不会扩展。 - AUTO，系统盘镜像空间会自动扩展为与flavor大小一致。  当前不支持该功能。</value>
        [JsonConverter(typeof(EnumClassConverter<OSDCFdiskConfigEnum>))]
        public class OSDCFdiskConfigEnum
        {
            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            public static readonly OSDCFdiskConfigEnum AUTO = new OSDCFdiskConfigEnum("AUTO");

            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            public static readonly OSDCFdiskConfigEnum MANUAL = new OSDCFdiskConfigEnum("MANUAL");

            public static readonly Dictionary<string, OSDCFdiskConfigEnum> StaticFields =
            new Dictionary<string, OSDCFdiskConfigEnum>()
            {
                {"AUTO", AUTO},
                {"MANUAL", MANUAL},
            };

            private string Value;

            public OSDCFdiskConfigEnum(string Value)
            {
                this.Value = Value;
            }

            public static OSDCFdiskConfigEnum FromValue(string Value)
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

                if (this.Equals(obj as OSDCFdiskConfigEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSDCFdiskConfigEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OSDCFdiskConfigEnum a, OSDCFdiskConfigEnum b)
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

            public static bool operator !=(OSDCFdiskConfigEnum a, OSDCFdiskConfigEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 镜像ID或者镜像资源的URL。  - 镜像ID示例：3b8d6fef-af77-42ab-b8b7-5a7f0f0af8f2 - 镜像URL示例：http://glance.openstack.example.com/images/3b8d6fef-af77-42ab-b8b7-5a7f0f0af8f2 - 指定卷作为系统卷创弹性云服务器时，不需填写该参数；非卷创建弹性云服务器时需填写有效的UUID参数，否则API将返回400错误。  &gt; 说明： &gt; - 对于部分规格的弹性云服务器，不能支持公有云平台提供的所有公共镜像。具体规格的镜像支持列表，请登录管理控制台，以“创建弹性云服务器”页面系统自动过滤的镜像信息为准，并在镜像服务页面查询镜像ID。 &gt; - 如果创建失败，请尝试修改参数配置。
        /// </summary>
        [JsonProperty("imageRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageRef { get; set; }

        /// <summary>
        /// 规格ID或URL。
        /// </summary>
        [JsonProperty("flavorRef", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 弹性云服务器名称，长度大于0小于256字节。  &gt; 说明： &gt;  &gt; 云服务器内部主机名(hostname)命名规则遵循 [RFC 952](https://tools.ietf.org/html/rfc952)和[RFC 1123](https://tools.ietf.org/html/rfc1123)命名规范，建议使用a-zA-z或0-9以及中划线\&quot;-\&quot;组成的名称命名，\&quot;_\&quot;将在弹性云服务器内部默认转化为\&quot;-\&quot;。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户自定义字段键值对。  &gt; - key的长度大于0小于256字节 &gt; - value的长度大于等于0小于256字节   系统预留字段  1. admin_pass：弹性云服务器密码        Windows弹性云服务器Administrator用户的密码。     &gt; 说明：     &gt; 创建密码方式鉴权的Windows弹性云服务器时为必选字段。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// 如果需要使用密码方式登录云服务器，可使用adminPass字段指定云服务器管理员帐户初始登录密码。其中，Linux管理员帐户为root，Windows管理员帐户为Administrator。
        /// </summary>
        [JsonProperty("adminPass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }

        /// <summary>
        /// 扩展属性，指定弹性云服务器存储设备的v2接口。是存储资源的新版本接口，指定卷场景不能批创弹性云服务器。  裸金属服务器场景不支持。
        /// </summary>
        [JsonProperty("block_device_mapping_v2", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaServerBlockDeviceMapping> BlockDeviceMappingV2 { get; set; }

        /// <summary>
        /// 扩展属性，开启后在弹性云服务器创建时挂载config_drive向弹性云服务器内部传递信息。  当前不支持该功能。
        /// </summary>
        [JsonProperty("config_drive", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigDrive { get; set; }

        /// <summary>
        /// 扩展属性，指定弹性云服务器的安全组，默认为default。  指定network创建弹性云服务器时该字段有效。对于已存在端口，安全组请求无效。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaServerSecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// 扩展属性，指定弹性云服务器的网卡信息。有多个租户网络时必须指定。 
        /// </summary>
        [JsonProperty("networks", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaServerNetwork> Networks { get; set; }

        /// <summary>
        /// 扩展属性，指定keypair的名称。
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 扩展属性，字符串长度小于65535，且必须是base64加密的。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 扩展属性，指定弹性云服务器所在的AZ。  创建弹性云服务器时需要填入该参数。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 扩展属性，是否支持返回批量创建弹性云服务器的reservation_id。通过返回的reservation_id，可以过滤查询到本次创建的弹性云服务器。  - true，返回reservation_id。 - false，返回弹性云服务器信息。  &gt; 说明： &gt;  &gt; 批量创建弹性云服务器时，支持使用该字段。
        /// </summary>
        [JsonProperty("return_reservation_id", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnReservationId { get; set; }

        /// <summary>
        /// 扩展属性，表示创建弹性云服务器最小数量。  默认值为1。  &gt; 说明： &gt;  &gt; 指定镜像创建弹性云服务器时，支持使用该字段。
        /// </summary>
        [JsonProperty("min_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinCount { get; set; }

        /// <summary>
        /// 表示创建弹性云服务器最大数量。  默认值与min_count的取值一致。  约束：  参数max_count的取值必须大于参数min_count的取值。  当min_count、max_count同时设置时，创弹性云服务器的数量取决于服务器的资源情况。根据资源情况，在min_count至max_count的取值范围内创建最大数量的弹性云服务器。  - 说明： -  - 指定镜像创建弹性云服务器时，支持使用该字段。
        /// </summary>
        [JsonProperty("max_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// diskConfig的方式，取值为AUTO、MANUAL。  - MANUAL，镜像空间不会扩展。 - AUTO，系统盘镜像空间会自动扩展为与flavor大小一致。  当前不支持该功能。
        /// </summary>
        [JsonProperty("OS-DCF:diskConfig", NullValueHandling = NullValueHandling.Ignore)]
        public OSDCFdiskConfigEnum OSDCFdiskConfig { get; set; }
        /// <summary>
        /// 扩展属性，表示弹性云服务器描述信息，默认为空字符串。  - 长度最多允许85个字符。 - 不能包含“&lt;” 和 “&gt;”等特殊符号。  &gt; 说明： &gt;  &gt; - V2接口不支持该字段。 &gt; - V2.1接口支持该字段，此时，需在请求Header中增加一组Key-Value值。其中，Key固定为“X-OpenStack-Nova-API-Version” ，Value为微版本号，当Value的值为2.19时，支持使用该字段。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaCreateServersOption {\n");
            sb.Append("  imageRef: ").Append(ImageRef).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("  blockDeviceMappingV2: ").Append(BlockDeviceMappingV2).Append("\n");
            sb.Append("  configDrive: ").Append(ConfigDrive).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  networks: ").Append(Networks).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  returnReservationId: ").Append(ReturnReservationId).Append("\n");
            sb.Append("  minCount: ").Append(MinCount).Append("\n");
            sb.Append("  maxCount: ").Append(MaxCount).Append("\n");
            sb.Append("  oSDCFdiskConfig: ").Append(OSDCFdiskConfig).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaCreateServersOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaCreateServersOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageRef == input.ImageRef ||
                    (this.ImageRef != null &&
                    this.ImageRef.Equals(input.ImageRef))
                ) && 
                (
                    this.FlavorRef == input.FlavorRef ||
                    (this.FlavorRef != null &&
                    this.FlavorRef.Equals(input.FlavorRef))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.AdminPass == input.AdminPass ||
                    (this.AdminPass != null &&
                    this.AdminPass.Equals(input.AdminPass))
                ) && 
                (
                    this.BlockDeviceMappingV2 == input.BlockDeviceMappingV2 ||
                    this.BlockDeviceMappingV2 != null &&
                    input.BlockDeviceMappingV2 != null &&
                    this.BlockDeviceMappingV2.SequenceEqual(input.BlockDeviceMappingV2)
                ) && 
                (
                    this.ConfigDrive == input.ConfigDrive ||
                    (this.ConfigDrive != null &&
                    this.ConfigDrive.Equals(input.ConfigDrive))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.Networks == input.Networks ||
                    this.Networks != null &&
                    input.Networks != null &&
                    this.Networks.SequenceEqual(input.Networks)
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.ReturnReservationId == input.ReturnReservationId ||
                    (this.ReturnReservationId != null &&
                    this.ReturnReservationId.Equals(input.ReturnReservationId))
                ) && 
                (
                    this.MinCount == input.MinCount ||
                    (this.MinCount != null &&
                    this.MinCount.Equals(input.MinCount))
                ) && 
                (
                    this.MaxCount == input.MaxCount ||
                    (this.MaxCount != null &&
                    this.MaxCount.Equals(input.MaxCount))
                ) && 
                (
                    this.OSDCFdiskConfig == input.OSDCFdiskConfig ||
                    (this.OSDCFdiskConfig != null &&
                    this.OSDCFdiskConfig.Equals(input.OSDCFdiskConfig))
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
                if (this.ImageRef != null)
                    hashCode = hashCode * 59 + this.ImageRef.GetHashCode();
                if (this.FlavorRef != null)
                    hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.AdminPass != null)
                    hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                if (this.BlockDeviceMappingV2 != null)
                    hashCode = hashCode * 59 + this.BlockDeviceMappingV2.GetHashCode();
                if (this.ConfigDrive != null)
                    hashCode = hashCode * 59 + this.ConfigDrive.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.Networks != null)
                    hashCode = hashCode * 59 + this.Networks.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ReturnReservationId != null)
                    hashCode = hashCode * 59 + this.ReturnReservationId.GetHashCode();
                if (this.MinCount != null)
                    hashCode = hashCode * 59 + this.MinCount.GetHashCode();
                if (this.MaxCount != null)
                    hashCode = hashCode * 59 + this.MaxCount.GetHashCode();
                if (this.OSDCFdiskConfig != null)
                    hashCode = hashCode * 59 + this.OSDCFdiskConfig.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
