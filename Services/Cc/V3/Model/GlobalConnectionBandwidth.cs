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
    /// 全域互联带宽实例的详细信息。
    /// </summary>
    public class GlobalConnectionBandwidth 
    {
        /// <summary>
        /// 功能说明：描述带宽类型，对应地理区间的城域、区域、大区、跨区四级： - TrsArea: 跨区带宽 - Area: 大区带宽 - SubArea: 区域带宽 - Region: 城域带宽
        /// </summary>
        /// <value>功能说明：描述带宽类型，对应地理区间的城域、区域、大区、跨区四级： - TrsArea: 跨区带宽 - Area: 大区带宽 - SubArea: 区域带宽 - Region: 城域带宽</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum REGION for value: Region
            /// </summary>
            public static readonly TypeEnum REGION = new TypeEnum("Region");

            /// <summary>
            /// Enum SUBAREA for value: SubArea
            /// </summary>
            public static readonly TypeEnum SUBAREA = new TypeEnum("SubArea");

            /// <summary>
            /// Enum AREA for value: Area
            /// </summary>
            public static readonly TypeEnum AREA = new TypeEnum("Area");

            /// <summary>
            /// Enum TRSAREA for value: TrsArea
            /// </summary>
            public static readonly TypeEnum TRSAREA = new TypeEnum("TrsArea");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "Region", REGION },
                { "SubArea", SUBAREA },
                { "Area", AREA },
                { "TrsArea", TRSAREA },
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
        /// 功能说明：绑定的服务类型。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络 - ALL: 所有实例类型
        /// </summary>
        /// <value>功能说明：绑定的服务类型。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络 - ALL: 所有实例类型</value>
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

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly BindingServiceEnum ALL = new BindingServiceEnum("ALL");

            private static readonly Dictionary<string, BindingServiceEnum> StaticFields =
            new Dictionary<string, BindingServiceEnum>()
            {
                { "CC", CC },
                { "GEIP", GEIP },
                { "GCN", GCN },
                { "GSN", GSN },
                { "ALL", ALL },
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
        /// 功能说明：描述计费类型，描述可选计费类型。默认开放按带宽计费，传统95计费租户白名单控制。 取值范围：     bwd: 按带宽计费     95: 按传统型95计费     95avr: 按传统型日95计费
        /// </summary>
        /// <value>功能说明：描述计费类型，描述可选计费类型。默认开放按带宽计费，传统95计费租户白名单控制。 取值范围：     bwd: 按带宽计费     95: 按传统型95计费     95avr: 按传统型日95计费</value>
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
        /// 功能说明：描述网络等级，从高到低分为铂金、金、银。默认金，其余租户白名单控制。 - Pt: 铂金 - Au: 金 - Ag: 银
        /// </summary>
        /// <value>功能说明：描述网络等级，从高到低分为铂金、金、银。默认金，其余租户白名单控制。 - Pt: 铂金 - Au: 金 - Ag: 银</value>
        [JsonConverter(typeof(EnumClassConverter<SlaLevelEnum>))]
        public class SlaLevelEnum
        {
            /// <summary>
            /// Enum PT for value: Pt
            /// </summary>
            public static readonly SlaLevelEnum PT = new SlaLevelEnum("Pt");

            /// <summary>
            /// Enum AU for value: Au
            /// </summary>
            public static readonly SlaLevelEnum AU = new SlaLevelEnum("Au");

            /// <summary>
            /// Enum AG for value: Ag
            /// </summary>
            public static readonly SlaLevelEnum AG = new SlaLevelEnum("Ag");

            private static readonly Dictionary<string, SlaLevelEnum> StaticFields =
            new Dictionary<string, SlaLevelEnum>()
            {
                { "Pt", PT },
                { "Au", AU },
                { "Ag", AG },
            };

            private string _value;

            public SlaLevelEnum()
            {

            }

            public SlaLevelEnum(string value)
            {
                _value = value;
            }

            public static SlaLevelEnum FromValue(string value)
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

                if (this.Equals(obj as SlaLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SlaLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SlaLevelEnum a, SlaLevelEnum b)
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

            public static bool operator !=(SlaLevelEnum a, SlaLevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明: 全域互联带宽状态。 取值范围：     NORMAL-正常     FREEZED-冻结状态
        /// </summary>
        /// <value>功能说明: 全域互联带宽状态。 取值范围：     NORMAL-正常     FREEZED-冻结状态</value>
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
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例描述。不支持 &lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 全域互联带宽跨境属性。
        /// </summary>
        [JsonProperty("bordercross", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bordercross { get; set; }

        /// <summary>
        /// 功能说明：描述带宽类型，对应地理区间的城域、区域、大区、跨区四级： - TrsArea: 跨区带宽 - Area: 大区带宽 - SubArea: 区域带宽 - Region: 城域带宽
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 功能说明：绑定的服务类型。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络 - ALL: 所有实例类型
        /// </summary>
        [JsonProperty("binding_service", NullValueHandling = NullValueHandling.Ignore)]
        public BindingServiceEnum BindingService { get; set; }
        /// <summary>
        /// 实例所属企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 功能说明：描述计费类型，描述可选计费类型。默认开放按带宽计费，传统95计费租户白名单控制。 取值范围：     bwd: 按带宽计费     95: 按传统型95计费     95avr: 按传统型日95计费
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 功能说明：全域互联带宽实例中的带宽值大小，单位Mbit/s。 取值范围：2-300Mbit/s
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 功能说明：描述网络等级，从高到低分为铂金、金、银。默认金，其余租户白名单控制。 - Pt: 铂金 - Au: 金 - Ag: 银
        /// </summary>
        [JsonProperty("sla_level", NullValueHandling = NullValueHandling.Ignore)]
        public SlaLevelEnum SlaLevel { get; set; }
        /// <summary>
        /// 功能说明：本端接入点的中英文名。通过HEADER里面的x-language控制，默认英文，zh-cn返回中文。
        /// </summary>
        [JsonProperty("local_area", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalArea { get; set; }

        /// <summary>
        /// 功能说明：远端接入点的中英文名。通过HEADER里面的x-language控制，默认英文，zh-cn返回中文。
        /// </summary>
        [JsonProperty("remote_area", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteArea { get; set; }

        /// <summary>
        /// 功能说明：本端接入点的编码。
        /// </summary>
        [JsonProperty("local_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalSiteCode { get; set; }

        /// <summary>
        /// 功能说明：远端接入点的编码。
        /// </summary>
        [JsonProperty("remote_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteSiteCode { get; set; }

        /// <summary>
        /// 功能说明: 全域互联带宽状态。 取值范围：     NORMAL-正常     FREEZED-冻结状态
        /// </summary>
        [JsonProperty("admin_state", NullValueHandling = NullValueHandling.Ignore)]
        public AdminStateEnum AdminState { get; set; }
        /// <summary>
        /// 功能说明: 全域互联带宽是否冻结。 取值范围：     true-冻结     false-非冻结
        /// </summary>
        [JsonProperty("frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Frozen { get; set; }

        /// <summary>
        /// 功能说明：线路规格编码UUID。
        /// </summary>
        [JsonProperty("spec_code_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCodeId { get; set; }

        /// <summary>
        /// 实例标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 实例创建时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 实例更新时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 有向连接列表。
        /// </summary>
        [JsonProperty("directional_connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectionalConnection> DirectionalConnections { get; set; }

        /// <summary>
        /// 功能说明: 全域互联带宽是否支持绑定多实例。 取值范围：     true-支持     false-不支持
        /// </summary>
        [JsonProperty("enable_share", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableShare { get; set; }

        /// <summary>
        /// 功能说明: 全域互联带宽绑定实例列表。
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<GlobalConnectionBandwidthAssociatedInstance> Instances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalConnectionBandwidth {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  bordercross: ").Append(Bordercross).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  bindingService: ").Append(BindingService).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  slaLevel: ").Append(SlaLevel).Append("\n");
            sb.Append("  localArea: ").Append(LocalArea).Append("\n");
            sb.Append("  remoteArea: ").Append(RemoteArea).Append("\n");
            sb.Append("  localSiteCode: ").Append(LocalSiteCode).Append("\n");
            sb.Append("  remoteSiteCode: ").Append(RemoteSiteCode).Append("\n");
            sb.Append("  adminState: ").Append(AdminState).Append("\n");
            sb.Append("  frozen: ").Append(Frozen).Append("\n");
            sb.Append("  specCodeId: ").Append(SpecCodeId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  directionalConnections: ").Append(DirectionalConnections).Append("\n");
            sb.Append("  enableShare: ").Append(EnableShare).Append("\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlobalConnectionBandwidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlobalConnectionBandwidth input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Bordercross != input.Bordercross || (this.Bordercross != null && !this.Bordercross.Equals(input.Bordercross))) return false;
            if (this.Type != input.Type) return false;
            if (this.BindingService != input.BindingService) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ChargeMode != input.ChargeMode) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.SlaLevel != input.SlaLevel) return false;
            if (this.LocalArea != input.LocalArea || (this.LocalArea != null && !this.LocalArea.Equals(input.LocalArea))) return false;
            if (this.RemoteArea != input.RemoteArea || (this.RemoteArea != null && !this.RemoteArea.Equals(input.RemoteArea))) return false;
            if (this.LocalSiteCode != input.LocalSiteCode || (this.LocalSiteCode != null && !this.LocalSiteCode.Equals(input.LocalSiteCode))) return false;
            if (this.RemoteSiteCode != input.RemoteSiteCode || (this.RemoteSiteCode != null && !this.RemoteSiteCode.Equals(input.RemoteSiteCode))) return false;
            if (this.AdminState != input.AdminState) return false;
            if (this.Frozen != input.Frozen || (this.Frozen != null && !this.Frozen.Equals(input.Frozen))) return false;
            if (this.SpecCodeId != input.SpecCodeId || (this.SpecCodeId != null && !this.SpecCodeId.Equals(input.SpecCodeId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.DirectionalConnections != input.DirectionalConnections || (this.DirectionalConnections != null && input.DirectionalConnections != null && !this.DirectionalConnections.SequenceEqual(input.DirectionalConnections))) return false;
            if (this.EnableShare != input.EnableShare || (this.EnableShare != null && !this.EnableShare.Equals(input.EnableShare))) return false;
            if (this.Instances != input.Instances || (this.Instances != null && input.Instances != null && !this.Instances.SequenceEqual(input.Instances))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Bordercross != null) hashCode = hashCode * 59 + this.Bordercross.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.BindingService.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.SlaLevel.GetHashCode();
                if (this.LocalArea != null) hashCode = hashCode * 59 + this.LocalArea.GetHashCode();
                if (this.RemoteArea != null) hashCode = hashCode * 59 + this.RemoteArea.GetHashCode();
                if (this.LocalSiteCode != null) hashCode = hashCode * 59 + this.LocalSiteCode.GetHashCode();
                if (this.RemoteSiteCode != null) hashCode = hashCode * 59 + this.RemoteSiteCode.GetHashCode();
                hashCode = hashCode * 59 + this.AdminState.GetHashCode();
                if (this.Frozen != null) hashCode = hashCode * 59 + this.Frozen.GetHashCode();
                if (this.SpecCodeId != null) hashCode = hashCode * 59 + this.SpecCodeId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DirectionalConnections != null) hashCode = hashCode * 59 + this.DirectionalConnections.GetHashCode();
                if (this.EnableShare != null) hashCode = hashCode * 59 + this.EnableShare.GetHashCode();
                if (this.Instances != null) hashCode = hashCode * 59 + this.Instances.GetHashCode();
                return hashCode;
            }
        }
    }
}
