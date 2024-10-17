using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPublicipsRequest 
    {
        /// <summary>
        /// 排序，形式为\&quot;sort_key&#x3D;id\&quot;  支持字段：id/public_ip_address/public_ipv6_address/ip_version/created_at/updated_at/public_border_group
        /// </summary>
        /// <value>排序，形式为\&quot;sort_key&#x3D;id\&quot;  支持字段：id/public_ip_address/public_ipv6_address/ip_version/created_at/updated_at/public_border_group</value>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum ID for value: id
            /// </summary>
            public static readonly SortKeyEnum ID = new SortKeyEnum("id");

            /// <summary>
            /// Enum PUBLIC_IP_ADDRESS for value: public_ip_address
            /// </summary>
            public static readonly SortKeyEnum PUBLIC_IP_ADDRESS = new SortKeyEnum("public_ip_address");

            /// <summary>
            /// Enum PUBLIC_IPV6_ADDRESS for value: public_ipv6_address
            /// </summary>
            public static readonly SortKeyEnum PUBLIC_IPV6_ADDRESS = new SortKeyEnum("public_ipv6_address");

            /// <summary>
            /// Enum IP_VERSION for value: ip_version
            /// </summary>
            public static readonly SortKeyEnum IP_VERSION = new SortKeyEnum("ip_version");

            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly SortKeyEnum CREATED_AT = new SortKeyEnum("created_at");

            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly SortKeyEnum UPDATED_AT = new SortKeyEnum("updated_at");

            /// <summary>
            /// Enum PUBLIC_BORDER_GROUP for value: public_border_group
            /// </summary>
            public static readonly SortKeyEnum PUBLIC_BORDER_GROUP = new SortKeyEnum("public_border_group");

            private static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                { "id", ID },
                { "public_ip_address", PUBLIC_IP_ADDRESS },
                { "public_ipv6_address", PUBLIC_IPV6_ADDRESS },
                { "ip_version", IP_VERSION },
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
                { "public_border_group", PUBLIC_BORDER_GROUP },
            };

            private string _value;

            public SortKeyEnum()
            {

            }

            public SortKeyEnum(string value)
            {
                _value = value;
            }

            public static SortKeyEnum FromValue(string value)
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

                if (this.Equals(obj as SortKeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortKeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortKeyEnum a, SortKeyEnum b)
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

            public static bool operator !=(SortKeyEnum a, SortKeyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序方向  取值范围：asc、desc
        /// </summary>
        /// <value>排序方向  取值范围：asc、desc</value>
        [JsonConverter(typeof(EnumClassConverter<SortDirEnum>))]
        public class SortDirEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly SortDirEnum ASC = new SortDirEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly SortDirEnum DESC = new SortDirEnum("desc");

            private static readonly Dictionary<string, SortDirEnum> StaticFields =
            new Dictionary<string, SortDirEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public SortDirEnum()
            {

            }

            public SortDirEnum(string value)
            {
                _value = value;
            }

            public static SortDirEnum FromValue(string value)
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

                if (this.Equals(obj as SortDirEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortDirEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortDirEnum a, SortDirEnum b)
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

            public static bool operator !=(SortDirEnum a, SortDirEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines ipVersion
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<IpVersionEnum>))]
        public class IpVersionEnum
        {
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly IpVersionEnum NUMBER_4 = new IpVersionEnum(4);

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly IpVersionEnum NUMBER_6 = new IpVersionEnum(6);

            private static readonly Dictionary<int?, IpVersionEnum> StaticFields =
            new Dictionary<int?, IpVersionEnum>()
            {
                { 4, NUMBER_4 },
                { 6, NUMBER_6 },
            };

            private int? _value;

            public IpVersionEnum()
            {

            }

            public IpVersionEnum(int? value)
            {
                _value = value;
            }

            public static IpVersionEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as IpVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpVersionEnum a, IpVersionEnum b)
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

            public static bool operator !=(IpVersionEnum a, IpVersionEnum b)
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
            /// Enum EIP for value: EIP
            /// </summary>
            public static readonly TypeEnum EIP = new TypeEnum("EIP");

            /// <summary>
            /// Enum DUALSTACK for value: DUALSTACK
            /// </summary>
            public static readonly TypeEnum DUALSTACK = new TypeEnum("DUALSTACK");

            /// <summary>
            /// Enum DUALSTACK_SUBNET for value: DUALSTACK_SUBNET
            /// </summary>
            public static readonly TypeEnum DUALSTACK_SUBNET = new TypeEnum("DUALSTACK_SUBNET");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "EIP", EIP },
                { "DUALSTACK", DUALSTACK },
                { "DUALSTACK_SUBNET", DUALSTACK_SUBNET },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines networkType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<NetworkTypeEnum>))]
        public class NetworkTypeEnum
        {
            /// <summary>
            /// Enum _5_TELCOM for value: 5_telcom
            /// </summary>
            public static readonly NetworkTypeEnum _5_TELCOM = new NetworkTypeEnum("5_telcom");

            /// <summary>
            /// Enum _5_UNION for value: 5_union
            /// </summary>
            public static readonly NetworkTypeEnum _5_UNION = new NetworkTypeEnum("5_union");

            /// <summary>
            /// Enum _5_BGP for value: 5_bgp
            /// </summary>
            public static readonly NetworkTypeEnum _5_BGP = new NetworkTypeEnum("5_bgp");

            /// <summary>
            /// Enum _5_SBGP for value: 5_sbgp
            /// </summary>
            public static readonly NetworkTypeEnum _5_SBGP = new NetworkTypeEnum("5_sbgp");

            /// <summary>
            /// Enum _5_IPV6 for value: 5_ipv6
            /// </summary>
            public static readonly NetworkTypeEnum _5_IPV6 = new NetworkTypeEnum("5_ipv6");

            /// <summary>
            /// Enum _5_GRAYBGP for value: 5_graybgp
            /// </summary>
            public static readonly NetworkTypeEnum _5_GRAYBGP = new NetworkTypeEnum("5_graybgp");

            private static readonly Dictionary<string, NetworkTypeEnum> StaticFields =
            new Dictionary<string, NetworkTypeEnum>()
            {
                { "5_telcom", _5_TELCOM },
                { "5_union", _5_UNION },
                { "5_bgp", _5_BGP },
                { "5_sbgp", _5_SBGP },
                { "5_ipv6", _5_IPV6 },
                { "5_graybgp", _5_GRAYBGP },
            };

            private string _value;

            public NetworkTypeEnum()
            {

            }

            public NetworkTypeEnum(string value)
            {
                _value = value;
            }

            public static NetworkTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NetworkTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NetworkTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NetworkTypeEnum a, NetworkTypeEnum b)
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

            public static bool operator !=(NetworkTypeEnum a, NetworkTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum FREEZED for value: FREEZED
            /// </summary>
            public static readonly StatusEnum FREEZED = new StatusEnum("FREEZED");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly StatusEnum DOWN = new StatusEnum("DOWN");

            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "FREEZED", FREEZED },
                { "DOWN", DOWN },
                { "ACTIVE", ACTIVE },
                { "ERROR", ERROR },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines bandwidthShareType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<BandwidthShareTypeEnum>))]
        public class BandwidthShareTypeEnum
        {
            /// <summary>
            /// Enum PER for value: PER
            /// </summary>
            public static readonly BandwidthShareTypeEnum PER = new BandwidthShareTypeEnum("PER");

            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly BandwidthShareTypeEnum WHOLE = new BandwidthShareTypeEnum("WHOLE");

            private static readonly Dictionary<string, BandwidthShareTypeEnum> StaticFields =
            new Dictionary<string, BandwidthShareTypeEnum>()
            {
                { "PER", PER },
                { "WHOLE", WHOLE },
            };

            private string _value;

            public BandwidthShareTypeEnum()
            {

            }

            public BandwidthShareTypeEnum(string value)
            {
                _value = value;
            }

            public static BandwidthShareTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BandwidthShareTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BandwidthShareTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BandwidthShareTypeEnum a, BandwidthShareTypeEnum b)
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

            public static bool operator !=(BandwidthShareTypeEnum a, BandwidthShareTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines bandwidthChargeMode
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<BandwidthChargeModeEnum>))]
        public class BandwidthChargeModeEnum
        {
            /// <summary>
            /// Enum BANDWIDTH for value: bandwidth
            /// </summary>
            public static readonly BandwidthChargeModeEnum BANDWIDTH = new BandwidthChargeModeEnum("bandwidth");

            /// <summary>
            /// Enum TRAFFIC for value: traffic
            /// </summary>
            public static readonly BandwidthChargeModeEnum TRAFFIC = new BandwidthChargeModeEnum("traffic");

            /// <summary>
            /// Enum _95PEAK_PLUS for value: 95peak_plus
            /// </summary>
            public static readonly BandwidthChargeModeEnum _95PEAK_PLUS = new BandwidthChargeModeEnum("95peak_plus");

            private static readonly Dictionary<string, BandwidthChargeModeEnum> StaticFields =
            new Dictionary<string, BandwidthChargeModeEnum>()
            {
                { "bandwidth", BANDWIDTH },
                { "traffic", TRAFFIC },
                { "95peak_plus", _95PEAK_PLUS },
            };

            private string _value;

            public BandwidthChargeModeEnum()
            {

            }

            public BandwidthChargeModeEnum(string value)
            {
                _value = value;
            }

            public static BandwidthChargeModeEnum FromValue(string value)
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

                if (this.Equals(obj as BandwidthChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BandwidthChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BandwidthChargeModeEnum a, BandwidthChargeModeEnum b)
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

            public static bool operator !=(BandwidthChargeModeEnum a, BandwidthChargeModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 根据订单模式过滤,   取值范围：YEARLY_MONTHLY、PAY_PER_USE
        /// </summary>
        /// <value>根据订单模式过滤,   取值范围：YEARLY_MONTHLY、PAY_PER_USE</value>
        [JsonConverter(typeof(EnumClassConverter<BillingModeEnum>))]
        public class BillingModeEnum
        {
            /// <summary>
            /// Enum YEARLY_MONTHLY for value: YEARLY_MONTHLY
            /// </summary>
            public static readonly BillingModeEnum YEARLY_MONTHLY = new BillingModeEnum("YEARLY_MONTHLY");

            /// <summary>
            /// Enum PAY_PER_USE for value: PAY_PER_USE
            /// </summary>
            public static readonly BillingModeEnum PAY_PER_USE = new BillingModeEnum("PAY_PER_USE");

            private static readonly Dictionary<string, BillingModeEnum> StaticFields =
            new Dictionary<string, BillingModeEnum>()
            {
                { "YEARLY_MONTHLY", YEARLY_MONTHLY },
                { "PAY_PER_USE", PAY_PER_USE },
            };

            private string _value;

            public BillingModeEnum()
            {

            }

            public BillingModeEnum(string value)
            {
                _value = value;
            }

            public static BillingModeEnum FromValue(string value)
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

                if (this.Equals(obj as BillingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BillingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BillingModeEnum a, BillingModeEnum b)
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

            public static bool operator !=(BillingModeEnum a, BillingModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines associateInstanceType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<AssociateInstanceTypeEnum>))]
        public class AssociateInstanceTypeEnum
        {
            /// <summary>
            /// Enum PORT for value: PORT
            /// </summary>
            public static readonly AssociateInstanceTypeEnum PORT = new AssociateInstanceTypeEnum("PORT");

            /// <summary>
            /// Enum NATGW for value: NATGW
            /// </summary>
            public static readonly AssociateInstanceTypeEnum NATGW = new AssociateInstanceTypeEnum("NATGW");

            /// <summary>
            /// Enum ELB for value: ELB
            /// </summary>
            public static readonly AssociateInstanceTypeEnum ELB = new AssociateInstanceTypeEnum("ELB");

            /// <summary>
            /// Enum VPN for value: VPN
            /// </summary>
            public static readonly AssociateInstanceTypeEnum VPN = new AssociateInstanceTypeEnum("VPN");

            /// <summary>
            /// Enum ELBV1 for value: ELBV1
            /// </summary>
            public static readonly AssociateInstanceTypeEnum ELBV1 = new AssociateInstanceTypeEnum("ELBV1");

            private static readonly Dictionary<string, AssociateInstanceTypeEnum> StaticFields =
            new Dictionary<string, AssociateInstanceTypeEnum>()
            {
                { "PORT", PORT },
                { "NATGW", NATGW },
                { "ELB", ELB },
                { "VPN", VPN },
                { "ELBV1", ELBV1 },
            };

            private string _value;

            public AssociateInstanceTypeEnum()
            {

            }

            public AssociateInstanceTypeEnum(string value)
            {
                _value = value;
            }

            public static AssociateInstanceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AssociateInstanceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssociateInstanceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssociateInstanceTypeEnum a, AssociateInstanceTypeEnum b)
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

            public static bool operator !=(AssociateInstanceTypeEnum a, AssociateInstanceTypeEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 分页查询起始的资源ID，为空时为查询第一页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 分页查询起始的资源序号
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页返回的个数取值范围：0~[2000]，其中2000为局点差异项，具体取值由局点决定
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 显示，形式为\&quot;fields&#x3D;id&amp;fields&#x3D;owner&amp;...\&quot;  支持字段：id/project_id/ip_version/type/public_ip_address/public_ipv6_address/network_type/status/description/created_at/updated_at/vnic/bandwidth/associate_instance_type/associate_instance_id/lock_status/billing_info/tags/enterprise_project_id/allow_share_bandwidth_types/public_border_group/alias/publicip_pool_name/publicip_pool_id
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// 排序，形式为\&quot;sort_key&#x3D;id\&quot;  支持字段：id/public_ip_address/public_ipv6_address/ip_version/created_at/updated_at/public_border_group
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public SortKeyEnum SortKey { get; set; }
        /// <summary>
        /// 排序方向  取值范围：asc、desc
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public SortDirEnum SortDir { get; set; }
        /// <summary>
        /// 根据id过滤
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 根据ip_version过滤  取值范围：4、6
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpVersionEnum> IpVersion { get; set; }
        /// <summary>
        /// 根据public_ip_address过滤
        /// </summary>
        [SDKProperty("public_ip_address", IsQuery = true)]
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicIpAddress { get; set; }

        /// <summary>
        /// 根据public_ip_address过滤，模糊搜索
        /// </summary>
        [SDKProperty("public_ip_address_like", IsQuery = true)]
        [JsonProperty("public_ip_address_like", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpAddressLike { get; set; }

        /// <summary>
        /// 根据public_ipv6_address过滤
        /// </summary>
        [SDKProperty("public_ipv6_address", IsQuery = true)]
        [JsonProperty("public_ipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicIpv6Address { get; set; }

        /// <summary>
        /// 根据public_ipv6_address过滤，模糊搜索
        /// </summary>
        [SDKProperty("public_ipv6_address_like", IsQuery = true)]
        [JsonProperty("public_ipv6_address_like", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpv6AddressLike { get; set; }

        /// <summary>
        /// 根据type过滤  取值范围：EIP、DUALSTACK、DUALSTACK_SUBNET  EIP: 弹性公网IP   DUALSTACK: 双栈IPV6   DUALSTACK_SUBNET: 双栈子网
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeEnum> Type { get; set; }
        /// <summary>
        /// 根据network_type过滤  取值范围：5_telcom、5_union、5_bgp、5_sbgp、5_ipv6、5_graybgp
        /// </summary>
        [SDKProperty("network_type", IsQuery = true)]
        [JsonProperty("network_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<NetworkTypeEnum> NetworkType { get; set; }
        /// <summary>
        /// 根据publicip_pool_name过滤  取值范围：5_telcom、5_union、5_bgp、5_sbgp、5_ipv6、5_graybgp、专属池名称等
        /// </summary>
        [SDKProperty("publicip_pool_name", IsQuery = true)]
        [JsonProperty("publicip_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicipPoolName { get; set; }

        /// <summary>
        /// 根据status过滤  取值范围：FREEZED、DOWN、ACTIVE、ERROR
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEnum> Status { get; set; }
        /// <summary>
        /// 根据alias模糊搜索
        /// </summary>
        [SDKProperty("alias_like", IsQuery = true)]
        [JsonProperty("alias_like", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasLike { get; set; }

        /// <summary>
        /// 根据alias过滤
        /// </summary>
        [SDKProperty("alias", IsQuery = true)]
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Alias { get; set; }

        /// <summary>
        /// 根据description过滤
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 根据private_ip_address过滤
        /// </summary>
        [SDKProperty("vnic.private_ip_address", IsQuery = true)]
        [JsonProperty("vnic.private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VnicPrivateIpAddress { get; set; }

        /// <summary>
        /// 根据private_ip_address模糊搜索
        /// </summary>
        [SDKProperty("vnic.private_ip_address_like", IsQuery = true)]
        [JsonProperty("vnic.private_ip_address_like", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicPrivateIpAddressLike { get; set; }

        /// <summary>
        /// 根据device_id过滤
        /// </summary>
        [SDKProperty("vnic.device_id", IsQuery = true)]
        [JsonProperty("vnic.device_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VnicDeviceId { get; set; }

        /// <summary>
        /// 根据device_owner过滤
        /// </summary>
        [SDKProperty("vnic.device_owner", IsQuery = true)]
        [JsonProperty("vnic.device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VnicDeviceOwner { get; set; }

        /// <summary>
        /// 根据vpc_id过滤
        /// </summary>
        [SDKProperty("vnic.vpc_id", IsQuery = true)]
        [JsonProperty("vnic.vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VnicVpcId { get; set; }

        /// <summary>
        /// 根据port_id过滤
        /// </summary>
        [SDKProperty("vnic.port_id", IsQuery = true)]
        [JsonProperty("vnic.port_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VnicPortId { get; set; }

        /// <summary>
        /// 根据device_owner_prefixlike模糊搜索
        /// </summary>
        [SDKProperty("vnic.device_owner_prefixlike", IsQuery = true)]
        [JsonProperty("vnic.device_owner_prefixlike", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicDeviceOwnerPrefixlike { get; set; }

        /// <summary>
        /// 根据instance_type过滤
        /// </summary>
        [SDKProperty("vnic.instance_type", IsQuery = true)]
        [JsonProperty("vnic.instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VnicInstanceType { get; set; }

        /// <summary>
        /// 根据instance_id过滤
        /// </summary>
        [SDKProperty("vnic.instance_id", IsQuery = true)]
        [JsonProperty("vnic.instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VnicInstanceId { get; set; }

        /// <summary>
        /// 根据id过滤
        /// </summary>
        [SDKProperty("bandwidth.id", IsQuery = true)]
        [JsonProperty("bandwidth.id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BandwidthId { get; set; }

        /// <summary>
        /// 根据name过滤
        /// </summary>
        [SDKProperty("bandwidth.name", IsQuery = true)]
        [JsonProperty("bandwidth.name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BandwidthName { get; set; }

        /// <summary>
        /// 根据name模糊过滤
        /// </summary>
        [SDKProperty("bandwidth.name_like", IsQuery = true)]
        [JsonProperty("bandwidth.name_like", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BandwidthNameLike { get; set; }

        /// <summary>
        /// 根据size过滤
        /// </summary>
        [SDKProperty("bandwidth.size", IsQuery = true)]
        [JsonProperty("bandwidth.size", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> BandwidthSize { get; set; }

        /// <summary>
        /// 根据share_type过滤
        /// </summary>
        [SDKProperty("bandwidth.share_type", IsQuery = true)]
        [JsonProperty("bandwidth.share_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<BandwidthShareTypeEnum> BandwidthShareType { get; set; }
        /// <summary>
        /// 根据charge_mode过滤
        /// </summary>
        [SDKProperty("bandwidth.charge_mode", IsQuery = true)]
        [JsonProperty("bandwidth.charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public List<BandwidthChargeModeEnum> BandwidthChargeMode { get; set; }
        /// <summary>
        /// 根据billing_info过滤
        /// </summary>
        [SDKProperty("billing_info", IsQuery = true)]
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BillingInfo { get; set; }

        /// <summary>
        /// 根据订单模式过滤,   取值范围：YEARLY_MONTHLY、PAY_PER_USE
        /// </summary>
        [SDKProperty("billing_mode", IsQuery = true)]
        [JsonProperty("billing_mode", NullValueHandling = NullValueHandling.Ignore)]
        public BillingModeEnum BillingMode { get; set; }
        /// <summary>
        /// 根据associate_instance_type过滤  取值范围：PORT、NATGW、ELB、VPN、ELBV1
        /// </summary>
        [SDKProperty("associate_instance_type", IsQuery = true)]
        [JsonProperty("associate_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssociateInstanceTypeEnum> AssociateInstanceType { get; set; }
        /// <summary>
        /// 根据associate_instance_id过滤
        /// </summary>
        [SDKProperty("associate_instance_id", IsQuery = true)]
        [JsonProperty("associate_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceId { get; set; }

        /// <summary>
        /// 根据enterprise_project_id过滤
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 根据public_border_group过滤
        /// </summary>
        [SDKProperty("public_border_group", IsQuery = true)]
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicBorderGroup { get; set; }

        /// <summary>
        /// 共享带宽类型，根据任一共享带宽类型过滤EIP列表。 可以指定多个带宽类型，不同的带宽类型间用逗号分隔。
        /// </summary>
        [SDKProperty("allow_share_bandwidth_type_any", IsQuery = true)]
        [JsonProperty("allow_share_bandwidth_type_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowShareBandwidthTypeAny { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPublicipsRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("  publicIpAddressLike: ").Append(PublicIpAddressLike).Append("\n");
            sb.Append("  publicIpv6Address: ").Append(PublicIpv6Address).Append("\n");
            sb.Append("  publicIpv6AddressLike: ").Append(PublicIpv6AddressLike).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  networkType: ").Append(NetworkType).Append("\n");
            sb.Append("  publicipPoolName: ").Append(PublicipPoolName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  aliasLike: ").Append(AliasLike).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  vnicPrivateIpAddress: ").Append(VnicPrivateIpAddress).Append("\n");
            sb.Append("  vnicPrivateIpAddressLike: ").Append(VnicPrivateIpAddressLike).Append("\n");
            sb.Append("  vnicDeviceId: ").Append(VnicDeviceId).Append("\n");
            sb.Append("  vnicDeviceOwner: ").Append(VnicDeviceOwner).Append("\n");
            sb.Append("  vnicVpcId: ").Append(VnicVpcId).Append("\n");
            sb.Append("  vnicPortId: ").Append(VnicPortId).Append("\n");
            sb.Append("  vnicDeviceOwnerPrefixlike: ").Append(VnicDeviceOwnerPrefixlike).Append("\n");
            sb.Append("  vnicInstanceType: ").Append(VnicInstanceType).Append("\n");
            sb.Append("  vnicInstanceId: ").Append(VnicInstanceId).Append("\n");
            sb.Append("  bandwidthId: ").Append(BandwidthId).Append("\n");
            sb.Append("  bandwidthName: ").Append(BandwidthName).Append("\n");
            sb.Append("  bandwidthNameLike: ").Append(BandwidthNameLike).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  bandwidthShareType: ").Append(BandwidthShareType).Append("\n");
            sb.Append("  bandwidthChargeMode: ").Append(BandwidthChargeMode).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  associateInstanceType: ").Append(AssociateInstanceType).Append("\n");
            sb.Append("  associateInstanceId: ").Append(AssociateInstanceId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  allowShareBandwidthTypeAny: ").Append(AllowShareBandwidthTypeAny).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPublicipsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPublicipsRequest input)
        {
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Fields != input.Fields || (this.Fields != null && input.Fields != null && !this.Fields.SequenceEqual(input.Fields))) return false;
            if (this.SortKey != input.SortKey) return false;
            if (this.SortDir != input.SortDir) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && input.IpVersion != null && !this.IpVersion.SequenceEqual(input.IpVersion))) return false;
            if (this.PublicIpAddress != input.PublicIpAddress || (this.PublicIpAddress != null && input.PublicIpAddress != null && !this.PublicIpAddress.SequenceEqual(input.PublicIpAddress))) return false;
            if (this.PublicIpAddressLike != input.PublicIpAddressLike || (this.PublicIpAddressLike != null && !this.PublicIpAddressLike.Equals(input.PublicIpAddressLike))) return false;
            if (this.PublicIpv6Address != input.PublicIpv6Address || (this.PublicIpv6Address != null && input.PublicIpv6Address != null && !this.PublicIpv6Address.SequenceEqual(input.PublicIpv6Address))) return false;
            if (this.PublicIpv6AddressLike != input.PublicIpv6AddressLike || (this.PublicIpv6AddressLike != null && !this.PublicIpv6AddressLike.Equals(input.PublicIpv6AddressLike))) return false;
            if (this.Type != input.Type || (this.Type != null && input.Type != null && !this.Type.SequenceEqual(input.Type))) return false;
            if (this.NetworkType != input.NetworkType || (this.NetworkType != null && input.NetworkType != null && !this.NetworkType.SequenceEqual(input.NetworkType))) return false;
            if (this.PublicipPoolName != input.PublicipPoolName || (this.PublicipPoolName != null && input.PublicipPoolName != null && !this.PublicipPoolName.SequenceEqual(input.PublicipPoolName))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.AliasLike != input.AliasLike || (this.AliasLike != null && !this.AliasLike.Equals(input.AliasLike))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && input.Alias != null && !this.Alias.SequenceEqual(input.Alias))) return false;
            if (this.Description != input.Description || (this.Description != null && input.Description != null && !this.Description.SequenceEqual(input.Description))) return false;
            if (this.VnicPrivateIpAddress != input.VnicPrivateIpAddress || (this.VnicPrivateIpAddress != null && input.VnicPrivateIpAddress != null && !this.VnicPrivateIpAddress.SequenceEqual(input.VnicPrivateIpAddress))) return false;
            if (this.VnicPrivateIpAddressLike != input.VnicPrivateIpAddressLike || (this.VnicPrivateIpAddressLike != null && !this.VnicPrivateIpAddressLike.Equals(input.VnicPrivateIpAddressLike))) return false;
            if (this.VnicDeviceId != input.VnicDeviceId || (this.VnicDeviceId != null && input.VnicDeviceId != null && !this.VnicDeviceId.SequenceEqual(input.VnicDeviceId))) return false;
            if (this.VnicDeviceOwner != input.VnicDeviceOwner || (this.VnicDeviceOwner != null && input.VnicDeviceOwner != null && !this.VnicDeviceOwner.SequenceEqual(input.VnicDeviceOwner))) return false;
            if (this.VnicVpcId != input.VnicVpcId || (this.VnicVpcId != null && input.VnicVpcId != null && !this.VnicVpcId.SequenceEqual(input.VnicVpcId))) return false;
            if (this.VnicPortId != input.VnicPortId || (this.VnicPortId != null && input.VnicPortId != null && !this.VnicPortId.SequenceEqual(input.VnicPortId))) return false;
            if (this.VnicDeviceOwnerPrefixlike != input.VnicDeviceOwnerPrefixlike || (this.VnicDeviceOwnerPrefixlike != null && !this.VnicDeviceOwnerPrefixlike.Equals(input.VnicDeviceOwnerPrefixlike))) return false;
            if (this.VnicInstanceType != input.VnicInstanceType || (this.VnicInstanceType != null && input.VnicInstanceType != null && !this.VnicInstanceType.SequenceEqual(input.VnicInstanceType))) return false;
            if (this.VnicInstanceId != input.VnicInstanceId || (this.VnicInstanceId != null && input.VnicInstanceId != null && !this.VnicInstanceId.SequenceEqual(input.VnicInstanceId))) return false;
            if (this.BandwidthId != input.BandwidthId || (this.BandwidthId != null && input.BandwidthId != null && !this.BandwidthId.SequenceEqual(input.BandwidthId))) return false;
            if (this.BandwidthName != input.BandwidthName || (this.BandwidthName != null && input.BandwidthName != null && !this.BandwidthName.SequenceEqual(input.BandwidthName))) return false;
            if (this.BandwidthNameLike != input.BandwidthNameLike || (this.BandwidthNameLike != null && input.BandwidthNameLike != null && !this.BandwidthNameLike.SequenceEqual(input.BandwidthNameLike))) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && input.BandwidthSize != null && !this.BandwidthSize.SequenceEqual(input.BandwidthSize))) return false;
            if (this.BandwidthShareType != input.BandwidthShareType || (this.BandwidthShareType != null && input.BandwidthShareType != null && !this.BandwidthShareType.SequenceEqual(input.BandwidthShareType))) return false;
            if (this.BandwidthChargeMode != input.BandwidthChargeMode || (this.BandwidthChargeMode != null && input.BandwidthChargeMode != null && !this.BandwidthChargeMode.SequenceEqual(input.BandwidthChargeMode))) return false;
            if (this.BillingInfo != input.BillingInfo || (this.BillingInfo != null && input.BillingInfo != null && !this.BillingInfo.SequenceEqual(input.BillingInfo))) return false;
            if (this.BillingMode != input.BillingMode) return false;
            if (this.AssociateInstanceType != input.AssociateInstanceType || (this.AssociateInstanceType != null && input.AssociateInstanceType != null && !this.AssociateInstanceType.SequenceEqual(input.AssociateInstanceType))) return false;
            if (this.AssociateInstanceId != input.AssociateInstanceId || (this.AssociateInstanceId != null && input.AssociateInstanceId != null && !this.AssociateInstanceId.SequenceEqual(input.AssociateInstanceId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && input.EnterpriseProjectId != null && !this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId))) return false;
            if (this.PublicBorderGroup != input.PublicBorderGroup || (this.PublicBorderGroup != null && input.PublicBorderGroup != null && !this.PublicBorderGroup.SequenceEqual(input.PublicBorderGroup))) return false;
            if (this.AllowShareBandwidthTypeAny != input.AllowShareBandwidthTypeAny || (this.AllowShareBandwidthTypeAny != null && input.AllowShareBandwidthTypeAny != null && !this.AllowShareBandwidthTypeAny.SequenceEqual(input.AllowShareBandwidthTypeAny))) return false;

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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Fields != null) hashCode = hashCode * 59 + this.Fields.GetHashCode();
                hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.PublicIpAddress != null) hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                if (this.PublicIpAddressLike != null) hashCode = hashCode * 59 + this.PublicIpAddressLike.GetHashCode();
                if (this.PublicIpv6Address != null) hashCode = hashCode * 59 + this.PublicIpv6Address.GetHashCode();
                if (this.PublicIpv6AddressLike != null) hashCode = hashCode * 59 + this.PublicIpv6AddressLike.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.PublicipPoolName != null) hashCode = hashCode * 59 + this.PublicipPoolName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AliasLike != null) hashCode = hashCode * 59 + this.AliasLike.GetHashCode();
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VnicPrivateIpAddress != null) hashCode = hashCode * 59 + this.VnicPrivateIpAddress.GetHashCode();
                if (this.VnicPrivateIpAddressLike != null) hashCode = hashCode * 59 + this.VnicPrivateIpAddressLike.GetHashCode();
                if (this.VnicDeviceId != null) hashCode = hashCode * 59 + this.VnicDeviceId.GetHashCode();
                if (this.VnicDeviceOwner != null) hashCode = hashCode * 59 + this.VnicDeviceOwner.GetHashCode();
                if (this.VnicVpcId != null) hashCode = hashCode * 59 + this.VnicVpcId.GetHashCode();
                if (this.VnicPortId != null) hashCode = hashCode * 59 + this.VnicPortId.GetHashCode();
                if (this.VnicDeviceOwnerPrefixlike != null) hashCode = hashCode * 59 + this.VnicDeviceOwnerPrefixlike.GetHashCode();
                if (this.VnicInstanceType != null) hashCode = hashCode * 59 + this.VnicInstanceType.GetHashCode();
                if (this.VnicInstanceId != null) hashCode = hashCode * 59 + this.VnicInstanceId.GetHashCode();
                if (this.BandwidthId != null) hashCode = hashCode * 59 + this.BandwidthId.GetHashCode();
                if (this.BandwidthName != null) hashCode = hashCode * 59 + this.BandwidthName.GetHashCode();
                if (this.BandwidthNameLike != null) hashCode = hashCode * 59 + this.BandwidthNameLike.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                hashCode = hashCode * 59 + this.BandwidthShareType.GetHashCode();
                hashCode = hashCode * 59 + this.BandwidthChargeMode.GetHashCode();
                if (this.BillingInfo != null) hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                hashCode = hashCode * 59 + this.AssociateInstanceType.GetHashCode();
                if (this.AssociateInstanceId != null) hashCode = hashCode * 59 + this.AssociateInstanceId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PublicBorderGroup != null) hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.AllowShareBandwidthTypeAny != null) hashCode = hashCode * 59 + this.AllowShareBandwidthTypeAny.GetHashCode();
                return hashCode;
            }
        }
    }
}
