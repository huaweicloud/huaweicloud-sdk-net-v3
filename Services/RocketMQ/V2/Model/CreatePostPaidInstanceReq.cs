using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 创建实例请求体。
    /// </summary>
    public class CreatePostPaidInstanceReq 
    {
        /// <summary>
        /// 消息引擎。取值填写为：reliability。
        /// </summary>
        /// <value>消息引擎。取值填写为：reliability。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineEnum>))]
        public class EngineEnum
        {
            /// <summary>
            /// Enum RELIABILITY for value: reliability
            /// </summary>
            public static readonly EngineEnum RELIABILITY = new EngineEnum("reliability");

            private static readonly Dictionary<string, EngineEnum> StaticFields =
            new Dictionary<string, EngineEnum>()
            {
                { "reliability", RELIABILITY },
            };

            private string _value;

            public EngineEnum()
            {

            }

            public EngineEnum(string value)
            {
                _value = value;
            }

            public static EngineEnum FromValue(string value)
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

                if (this.Equals(obj as EngineEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineEnum a, EngineEnum b)
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

            public static bool operator !=(EngineEnum a, EngineEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 消息引擎的版本。取值填写为：[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[5.x](tag:hcs,fcs)。
        /// </summary>
        /// <value>消息引擎的版本。取值填写为：[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[5.x](tag:hcs,fcs)。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineVersionEnum>))]
        public class EngineVersionEnum
        {
            /// <summary>
            /// Enum _4_8_0_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_5_X_TAG_HCS_ for value: [4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[5.x](tag:hcs)
            /// </summary>
            public static readonly EngineVersionEnum _4_8_0_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_5_X_TAG_HCS_ = new EngineVersionEnum("[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[5.x](tag:hcs)");

            private static readonly Dictionary<string, EngineVersionEnum> StaticFields =
            new Dictionary<string, EngineVersionEnum>()
            {
                { "[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[5.x](tag:hcs)", _4_8_0_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_5_X_TAG_HCS_ },
            };

            private string _value;

            public EngineVersionEnum()
            {

            }

            public EngineVersionEnum(string value)
            {
                _value = value;
            }

            public static EngineVersionEnum FromValue(string value)
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

                if (this.Equals(obj as EngineVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineVersionEnum a, EngineVersionEnum b)
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

            public static bool operator !=(EngineVersionEnum a, EngineVersionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// RocketMQ实例规格。[x86环境后缀为.x86，arm环境为.arm。](tag:hcs,fcs)   - [c6.2u8g.cluster.x86或c6.2u8g.cluster.arm：单个代理最大分区数50，单个代理最大消费组数100](tag:fcs)   - [c6.4u8g.cluster：单个代理最大Topic数4000，单个代理最大消费组数4000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.4u16g.cluster.x86或c6.4u16g.cluster.arm：单个代理最大分区数100，单个代理最大消费组数200](tag:hcs)   - [c6.8u16g.cluster：单个代理最大Topic数8000，单个代理最大消费组数8000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.8u32g.cluster.x86或c6.8u32g.cluster.arm：单个代理最大Topic数200，单个代理最大消费组数400](tag:hcs,fcs)   - [c6.12u24g.cluster：单个代理最大Topic数12000，单个代理最大消费组数12000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.16u64g.cluster.x86或c6.16u64g.cluster.arm：单个代理最大Topic数300，单个代理最大消费组数600](tag:hcs,fcs)   - [c6.16u32g.cluster：单个代理最大Topic数16000，单个代理最大消费组数16000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.32u128g.cluster.x86或c6.32u128g.cluster.arm：单个代理最大Topic数400，单个代理最大消费组数800](tag:hcs,fcs)
        /// </summary>
        /// <value>RocketMQ实例规格。[x86环境后缀为.x86，arm环境为.arm。](tag:hcs,fcs)   - [c6.2u8g.cluster.x86或c6.2u8g.cluster.arm：单个代理最大分区数50，单个代理最大消费组数100](tag:fcs)   - [c6.4u8g.cluster：单个代理最大Topic数4000，单个代理最大消费组数4000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.4u16g.cluster.x86或c6.4u16g.cluster.arm：单个代理最大分区数100，单个代理最大消费组数200](tag:hcs)   - [c6.8u16g.cluster：单个代理最大Topic数8000，单个代理最大消费组数8000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.8u32g.cluster.x86或c6.8u32g.cluster.arm：单个代理最大Topic数200，单个代理最大消费组数400](tag:hcs,fcs)   - [c6.12u24g.cluster：单个代理最大Topic数12000，单个代理最大消费组数12000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.16u64g.cluster.x86或c6.16u64g.cluster.arm：单个代理最大Topic数300，单个代理最大消费组数600](tag:hcs,fcs)   - [c6.16u32g.cluster：单个代理最大Topic数16000，单个代理最大消费组数16000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.32u128g.cluster.x86或c6.32u128g.cluster.arm：单个代理最大Topic数400，单个代理最大消费组数800](tag:hcs,fcs)</value>
        [JsonConverter(typeof(EnumClassConverter<ProductIdEnum>))]
        public class ProductIdEnum
        {
            /// <summary>
            /// Enum _C6_4U8G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_4U16G_CLUSTER_X86_TAG_HCS_FCS_ for value: [c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.4u16g.cluster.x86](tag:hcs,fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_4U8G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_4U16G_CLUSTER_X86_TAG_HCS_FCS_ = new ProductIdEnum("[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.4u16g.cluster.x86](tag:hcs,fcs)");

            /// <summary>
            /// Enum _C6_8U16G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_8U32G_CLUSTER_X86_TAG_HCS_FCS_ for value: [c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.8u32g.cluster.x86](tag:hcs,fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_8U16G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_8U32G_CLUSTER_X86_TAG_HCS_FCS_ = new ProductIdEnum("[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.8u32g.cluster.x86](tag:hcs,fcs)");

            /// <summary>
            /// Enum _C6_12U24G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_16U64G_CLUSTER_X86_TAG_HCS_FCS_ for value: [c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.16u64g.cluster.x86](tag:hcs,fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_12U24G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_16U64G_CLUSTER_X86_TAG_HCS_FCS_ = new ProductIdEnum("[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.16u64g.cluster.x86](tag:hcs,fcs)");

            /// <summary>
            /// Enum _C6_16U32G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_32U128G_CLUSTER_X86_TAG_HCS_FCS_ for value: [c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.32u128g.cluster.x86](tag:hcs,fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_16U32G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_32U128G_CLUSTER_X86_TAG_HCS_FCS_ = new ProductIdEnum("[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.32u128g.cluster.x86](tag:hcs,fcs)");

            /// <summary>
            /// Enum _C6_2U8G_CLUSTER_X86_TAG_FCS_ for value: [c6.2u8g.cluster.x86](tag:fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_2U8G_CLUSTER_X86_TAG_FCS_ = new ProductIdEnum("[c6.2u8g.cluster.x86](tag:fcs)");

            /// <summary>
            /// Enum _C6_2U8G_CLUSTER_ARM_TAG_FCS_ for value: [c6.2u8g.cluster.arm](tag:fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_2U8G_CLUSTER_ARM_TAG_FCS_ = new ProductIdEnum("[c6.2u8g.cluster.arm](tag:fcs)");

            /// <summary>
            /// Enum _C6_4U16G_CLUSTER_ARM_TAG_HCS_FCS_ for value: [c6.4u16g.cluster.arm](tag:hcs,fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_4U16G_CLUSTER_ARM_TAG_HCS_FCS_ = new ProductIdEnum("[c6.4u16g.cluster.arm](tag:hcs,fcs)");

            /// <summary>
            /// Enum _C6_8U32G_CLUSTER_ARM_TAG_HCS_FCS_ for value: [c6.8u32g.cluster.arm](tag:hcs,fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_8U32G_CLUSTER_ARM_TAG_HCS_FCS_ = new ProductIdEnum("[c6.8u32g.cluster.arm](tag:hcs,fcs)");

            /// <summary>
            /// Enum _C6_16U64G_CLUSTER_ARM_TAG_HCS_FCS_ for value: [c6.16u64g.cluster.arm](tag:hcs,fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_16U64G_CLUSTER_ARM_TAG_HCS_FCS_ = new ProductIdEnum("[c6.16u64g.cluster.arm](tag:hcs,fcs)");

            /// <summary>
            /// Enum _C6_32U128G_CLUSTER_ARM_TAG_HCS_FCS_ for value: [c6.32u128g.cluster.arm](tag:hcs,fcs)
            /// </summary>
            public static readonly ProductIdEnum _C6_32U128G_CLUSTER_ARM_TAG_HCS_FCS_ = new ProductIdEnum("[c6.32u128g.cluster.arm](tag:hcs,fcs)");

            private static readonly Dictionary<string, ProductIdEnum> StaticFields =
            new Dictionary<string, ProductIdEnum>()
            {
                { "[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.4u16g.cluster.x86](tag:hcs,fcs)", _C6_4U8G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_4U16G_CLUSTER_X86_TAG_HCS_FCS_ },
                { "[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.8u32g.cluster.x86](tag:hcs,fcs)", _C6_8U16G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_8U32G_CLUSTER_X86_TAG_HCS_FCS_ },
                { "[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.16u64g.cluster.x86](tag:hcs,fcs)", _C6_12U24G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_16U64G_CLUSTER_X86_TAG_HCS_FCS_ },
                { "[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.32u128g.cluster.x86](tag:hcs,fcs)", _C6_16U32G_CLUSTER_TAG_HWS_HWS_EU_HWS_HK_OCB_HWS_OCB_CTC_G42_HK_G42_TM_SBC_HK_SBC_HK_TM_DT_C6_32U128G_CLUSTER_X86_TAG_HCS_FCS_ },
                { "[c6.2u8g.cluster.x86](tag:fcs)", _C6_2U8G_CLUSTER_X86_TAG_FCS_ },
                { "[c6.2u8g.cluster.arm](tag:fcs)", _C6_2U8G_CLUSTER_ARM_TAG_FCS_ },
                { "[c6.4u16g.cluster.arm](tag:hcs,fcs)", _C6_4U16G_CLUSTER_ARM_TAG_HCS_FCS_ },
                { "[c6.8u32g.cluster.arm](tag:hcs,fcs)", _C6_8U32G_CLUSTER_ARM_TAG_HCS_FCS_ },
                { "[c6.16u64g.cluster.arm](tag:hcs,fcs)", _C6_16U64G_CLUSTER_ARM_TAG_HCS_FCS_ },
                { "[c6.32u128g.cluster.arm](tag:hcs,fcs)", _C6_32U128G_CLUSTER_ARM_TAG_HCS_FCS_ },
            };

            private string _value;

            public ProductIdEnum()
            {

            }

            public ProductIdEnum(string value)
            {
                _value = value;
            }

            public static ProductIdEnum FromValue(string value)
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

                if (this.Equals(obj as ProductIdEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProductIdEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProductIdEnum a, ProductIdEnum b)
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

            public static bool operator !=(ProductIdEnum a, ProductIdEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 存储IO规格。   - dms.physical.storage.high.v2: 高IO类型磁盘   - dms.physical.storage.ultra.v2: 超高IO类型磁盘
        /// </summary>
        /// <value>存储IO规格。   - dms.physical.storage.high.v2: 高IO类型磁盘   - dms.physical.storage.ultra.v2: 超高IO类型磁盘</value>
        [JsonConverter(typeof(EnumClassConverter<StorageSpecCodeEnum>))]
        public class StorageSpecCodeEnum
        {
            /// <summary>
            /// Enum DMS_PHYSICAL_STORAGE_HIGH_V2 for value: dms.physical.storage.high.v2
            /// </summary>
            public static readonly StorageSpecCodeEnum DMS_PHYSICAL_STORAGE_HIGH_V2 = new StorageSpecCodeEnum("dms.physical.storage.high.v2");

            /// <summary>
            /// Enum DMS_PHYSICAL_STORAGE_ULTRA_V2 for value: dms.physical.storage.ultra.v2
            /// </summary>
            public static readonly StorageSpecCodeEnum DMS_PHYSICAL_STORAGE_ULTRA_V2 = new StorageSpecCodeEnum("dms.physical.storage.ultra.v2");

            private static readonly Dictionary<string, StorageSpecCodeEnum> StaticFields =
            new Dictionary<string, StorageSpecCodeEnum>()
            {
                { "dms.physical.storage.high.v2", DMS_PHYSICAL_STORAGE_HIGH_V2 },
                { "dms.physical.storage.ultra.v2", DMS_PHYSICAL_STORAGE_ULTRA_V2 },
            };

            private string _value;

            public StorageSpecCodeEnum()
            {

            }

            public StorageSpecCodeEnum(string value)
            {
                _value = value;
            }

            public static StorageSpecCodeEnum FromValue(string value)
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

                if (this.Equals(obj as StorageSpecCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StorageSpecCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StorageSpecCodeEnum a, StorageSpecCodeEnum b)
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

            public static bool operator !=(StorageSpecCodeEnum a, StorageSpecCodeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例名称。  由英文字符开头，只能由英文字母、数字、中划线、下划线组成，长度为4~64的字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例的描述信息。  长度不超过1024的字符串。[且字符串不能包含\&quot;&gt;\&quot;与\&quot;&lt;\&quot;，字符串首字符不能为\&quot;&#x3D;\&quot;,\&quot;+\&quot;,\&quot;-\&quot;,\&quot;@\&quot;的全角和半角字符。](tag:hcs)  &gt; \\与\&quot;在json报文中属于特殊字符，如果参数值中需要显示\\或者\&quot;字符，请在字符前增加转义字符\\，比如\\\\或者\\\&quot;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 消息引擎。取值填写为：reliability。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }
        /// <summary>
        /// 消息引擎的版本。取值填写为：[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[5.x](tag:hcs,fcs)。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public EngineVersionEnum EngineVersion { get; set; }
        /// <summary>
        /// 存储空间。
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// 虚拟私有云ID。  获取方法如下：登录虚拟私有云服务的控制台界面，在虚拟私有云的详情页面查找VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网信息。  获取方法如下：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找网络ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 指定实例所属的安全组。  获取方法如下：登录虚拟私有云服务的控制台界面，在安全组的详情页面查找安全组ID。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 创建节点到指定且有资源的可用区ID。请参考[查询可用区信息](ListAvailableZones.xml)获取可用区ID。 该参数不能为空数组或者数组的值为空， 请注意查看该可用区是否有资源。  创建RocketMQ实例，支持节点部署在1个或[3个及3个以上的可用区。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[2个可用区。](tag:fcs)在为节点指定可用区时，用逗号分隔开。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// RocketMQ实例规格。[x86环境后缀为.x86，arm环境为.arm。](tag:hcs,fcs)   - [c6.2u8g.cluster.x86或c6.2u8g.cluster.arm：单个代理最大分区数50，单个代理最大消费组数100](tag:fcs)   - [c6.4u8g.cluster：单个代理最大Topic数4000，单个代理最大消费组数4000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.4u16g.cluster.x86或c6.4u16g.cluster.arm：单个代理最大分区数100，单个代理最大消费组数200](tag:hcs)   - [c6.8u16g.cluster：单个代理最大Topic数8000，单个代理最大消费组数8000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.8u32g.cluster.x86或c6.8u32g.cluster.arm：单个代理最大Topic数200，单个代理最大消费组数400](tag:hcs,fcs)   - [c6.12u24g.cluster：单个代理最大Topic数12000，单个代理最大消费组数12000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.16u64g.cluster.x86或c6.16u64g.cluster.arm：单个代理最大Topic数300，单个代理最大消费组数600](tag:hcs,fcs)   - [c6.16u32g.cluster：单个代理最大Topic数16000，单个代理最大消费组数16000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt)[c6.32u128g.cluster.x86或c6.32u128g.cluster.arm：单个代理最大Topic数400，单个代理最大消费组数800](tag:hcs,fcs)
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public ProductIdEnum ProductId { get; set; }
        /// <summary>
        /// 是否打开SSL加密访问。 - true：打开SSL加密访问。 - false：不打开SSL加密访问。
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// 存储IO规格。   - dms.physical.storage.high.v2: 高IO类型磁盘   - dms.physical.storage.ultra.v2: 超高IO类型磁盘
        /// </summary>
        [JsonProperty("storage_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public StorageSpecCodeEnum StorageSpecCode { get; set; }
        /// <summary>
        /// 企业项目ID。若为企业项目账号，该参数必填。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否开启访问控制列表。
        /// </summary>
        [JsonProperty("enable_acl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAcl { get; set; }

        /// <summary>
        /// 是否支持IPv6。   - true：支持   - false：不支持
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// 是否开启公网访问功能。默认不开启公网。 - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// 实例绑定的弹性IP地址的ID。  以英文逗号隔开多个弹性IP地址的ID。  如果开启了公网访问功能（即enable_publicip为true），该字段为必选。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// 代理个数。
        /// </summary>
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePostPaidInstanceReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  storageSpace: ").Append(StorageSpace).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enableAcl: ").Append(EnableAcl).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  brokerNum: ").Append(BrokerNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePostPaidInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePostPaidInstanceReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Engine != input.Engine) return false;
            if (this.EngineVersion != input.EngineVersion) return false;
            if (this.StorageSpace != input.StorageSpace || (this.StorageSpace != null && !this.StorageSpace.Equals(input.StorageSpace))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.ProductId != input.ProductId) return false;
            if (this.SslEnable != input.SslEnable || (this.SslEnable != null && !this.SslEnable.Equals(input.SslEnable))) return false;
            if (this.StorageSpecCode != input.StorageSpecCode) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnableAcl != input.EnableAcl || (this.EnableAcl != null && !this.EnableAcl.Equals(input.EnableAcl))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.EnablePublicip != input.EnablePublicip || (this.EnablePublicip != null && !this.EnablePublicip.Equals(input.EnablePublicip))) return false;
            if (this.PublicipId != input.PublicipId || (this.PublicipId != null && !this.PublicipId.Equals(input.PublicipId))) return false;
            if (this.BrokerNum != input.BrokerNum || (this.BrokerNum != null && !this.BrokerNum.Equals(input.BrokerNum))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Engine.GetHashCode();
                hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.StorageSpace != null) hashCode = hashCode * 59 + this.StorageSpace.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SslEnable != null) hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnableAcl != null) hashCode = hashCode * 59 + this.EnableAcl.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.EnablePublicip != null) hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.PublicipId != null) hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.BrokerNum != null) hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
