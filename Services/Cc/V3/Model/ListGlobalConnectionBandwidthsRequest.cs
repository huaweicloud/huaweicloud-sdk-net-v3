using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListGlobalConnectionBandwidthsRequest 
    {
        /// <summary>
        /// Defines instanceType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<InstanceTypeEnum>))]
        public class InstanceTypeEnum
        {
            /// <summary>
            /// Enum CC for value: CC
            /// </summary>
            public static readonly InstanceTypeEnum CC = new InstanceTypeEnum("CC");

            /// <summary>
            /// Enum GEIP for value: GEIP
            /// </summary>
            public static readonly InstanceTypeEnum GEIP = new InstanceTypeEnum("GEIP");

            /// <summary>
            /// Enum GCN for value: GCN
            /// </summary>
            public static readonly InstanceTypeEnum GCN = new InstanceTypeEnum("GCN");

            /// <summary>
            /// Enum GSN for value: GSN
            /// </summary>
            public static readonly InstanceTypeEnum GSN = new InstanceTypeEnum("GSN");

            private static readonly Dictionary<string, InstanceTypeEnum> StaticFields =
            new Dictionary<string, InstanceTypeEnum>()
            {
                { "CC", CC },
                { "GEIP", GEIP },
                { "GCN", GCN },
                { "GSN", GSN },
            };

            private string _value;

            public InstanceTypeEnum()
            {

            }

            public InstanceTypeEnum(string value)
            {
                _value = value;
            }

            public static InstanceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceTypeEnum a, InstanceTypeEnum b)
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

            public static bool operator !=(InstanceTypeEnum a, InstanceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines bindingService
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<BindingServiceEnum>))]
        public class BindingServiceEnum
        {
            /// <summary>
            /// Enum CC for value: CC
            /// </summary>
            public static readonly BindingServiceEnum CC = new BindingServiceEnum("CC");

            /// <summary>
            /// Enum GEIP for value: GEIP
            /// </summary>
            public static readonly BindingServiceEnum GEIP = new BindingServiceEnum("GEIP");

            /// <summary>
            /// Enum GCN for value: GCN
            /// </summary>
            public static readonly BindingServiceEnum GCN = new BindingServiceEnum("GCN");

            /// <summary>
            /// Enum GSN for value: GSN
            /// </summary>
            public static readonly BindingServiceEnum GSN = new BindingServiceEnum("GSN");

            private static readonly Dictionary<string, BindingServiceEnum> StaticFields =
            new Dictionary<string, BindingServiceEnum>()
            {
                { "CC", CC },
                { "GEIP", GEIP },
                { "GCN", GCN },
                { "GSN", GSN },
            };

            private string _value;

            public BindingServiceEnum()
            {

            }

            public BindingServiceEnum(string value)
            {
                _value = value;
            }

            public static BindingServiceEnum FromValue(string value)
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

                if (this.Equals(obj as BindingServiceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BindingServiceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BindingServiceEnum a, BindingServiceEnum b)
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

            public static bool operator !=(BindingServiceEnum a, BindingServiceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines type
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum TRSAREA for value: TrsArea
            /// </summary>
            public static readonly TypeEnum TRSAREA = new TypeEnum("TrsArea");

            /// <summary>
            /// Enum AREA for value: Area
            /// </summary>
            public static readonly TypeEnum AREA = new TypeEnum("Area");

            /// <summary>
            /// Enum SUBAREA for value: SubArea
            /// </summary>
            public static readonly TypeEnum SUBAREA = new TypeEnum("SubArea");

            /// <summary>
            /// Enum REGION for value: Region
            /// </summary>
            public static readonly TypeEnum REGION = new TypeEnum("Region");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "TrsArea", TRSAREA },
                { "Area", AREA },
                { "SubArea", SUBAREA },
                { "Region", REGION },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines adminState
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<AdminStateEnum>))]
        public class AdminStateEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly AdminStateEnum NORMAL = new AdminStateEnum("NORMAL");

            /// <summary>
            /// Enum FREEZED for value: FREEZED
            /// </summary>
            public static readonly AdminStateEnum FREEZED = new AdminStateEnum("FREEZED");

            private static readonly Dictionary<string, AdminStateEnum> StaticFields =
            new Dictionary<string, AdminStateEnum>()
            {
                { "NORMAL", NORMAL },
                { "FREEZED", FREEZED },
            };

            private string _value;

            public AdminStateEnum()
            {

            }

            public AdminStateEnum(string value)
            {
                _value = value;
            }

            public static AdminStateEnum FromValue(string value)
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

                if (this.Equals(obj as AdminStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AdminStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AdminStateEnum a, AdminStateEnum b)
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

            public static bool operator !=(AdminStateEnum a, AdminStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines chargeMode
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum BWD for value: bwd
            /// </summary>
            public static readonly ChargeModeEnum BWD = new ChargeModeEnum("bwd");

            /// <summary>
            /// Enum _95 for value: 95
            /// </summary>
            public static readonly ChargeModeEnum _95 = new ChargeModeEnum("95");

            /// <summary>
            /// Enum _95AVR for value: 95avr
            /// </summary>
            public static readonly ChargeModeEnum _95AVR = new ChargeModeEnum("95avr");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "bwd", BWD },
                { "95", _95 },
                { "95avr", _95AVR },
            };

            private string _value;

            public ChargeModeEnum()
            {

            }

            public ChargeModeEnum(string value)
            {
                _value = value;
            }

            public static ChargeModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargeModeEnum a, ChargeModeEnum b)
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

            public static bool operator !=(ChargeModeEnum a, ChargeModeEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 每页返回的个数。 取值范围：1~2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 翻页信息，从上次API调用返回的翻页数据中获取，可填写前一页marker或者后一页marker，填入前一页previous_marker就向前翻页，后一页next_marker就向后翻页。 翻页过程中，查询条件不能修改，包括过滤条件、排序条件、limit。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 根据ID查询，可查询多个ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 根据名称查询，可查询多个名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 根据企业项目ID过滤列表。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 根据绑定实例id过滤全域互联带宽列表。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// 根据绑定实例类型过滤全域互联带宽列表。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络
        /// </summary>
        [SDKProperty("instance_type", IsQuery = true)]
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceTypeEnum> InstanceType { get; set; }
        /// <summary>
        /// 根据支持绑定实例类型过滤全域互联带宽列表。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络
        /// </summary>
        [SDKProperty("binding_service", IsQuery = true)]
        [JsonProperty("binding_service", NullValueHandling = NullValueHandling.Ignore)]
        public List<BindingServiceEnum> BindingService { get; set; }
        /// <summary>
        /// 根据带宽类型过滤全域互联带宽列表。带宽类型： - TrsArea: 跨区带宽 - Area: 大区带宽 - SubArea: 区域带宽 - Region: 城域带宽
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeEnum> Type { get; set; }
        /// <summary>
        /// 根据带宽状态过滤全域互联带宽列表： - NORMAL: 正常 - FREEZED: 冻结
        /// </summary>
        [SDKProperty("admin_state", IsQuery = true)]
        [JsonProperty("admin_state", NullValueHandling = NullValueHandling.Ignore)]
        public List<AdminStateEnum> AdminState { get; set; }
        /// <summary>
        /// 根据计费方式过滤全域互联带宽列表： - bwd: 按带宽计费 - &#39;95&#39;: 按传统型95计费 - 95avr (日95计费)
        /// </summary>
        [SDKProperty("charge_mode", IsQuery = true)]
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChargeModeEnum> ChargeMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGlobalConnectionBandwidthsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  bindingService: ").Append(BindingService).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  adminState: ").Append(AdminState).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGlobalConnectionBandwidthsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGlobalConnectionBandwidthsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && input.EnterpriseProjectId != null && !this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && input.InstanceId != null && !this.InstanceId.SequenceEqual(input.InstanceId))) return false;
            if (this.InstanceType != input.InstanceType || (this.InstanceType != null && input.InstanceType != null && !this.InstanceType.SequenceEqual(input.InstanceType))) return false;
            if (this.BindingService != input.BindingService || (this.BindingService != null && input.BindingService != null && !this.BindingService.SequenceEqual(input.BindingService))) return false;
            if (this.Type != input.Type || (this.Type != null && input.Type != null && !this.Type.SequenceEqual(input.Type))) return false;
            if (this.AdminState != input.AdminState || (this.AdminState != null && input.AdminState != null && !this.AdminState.SequenceEqual(input.AdminState))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && input.ChargeMode != null && !this.ChargeMode.SequenceEqual(input.ChargeMode))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                hashCode = hashCode * 59 + this.BindingService.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.AdminState.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
