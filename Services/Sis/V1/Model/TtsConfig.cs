using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 语音合成配置数据结构。
    /// </summary>
    public class TtsConfig 
    {
        /// <summary>
        /// 语音格式头：wav、mp3、pcm。 默认：wav
        /// </summary>
        /// <value>语音格式头：wav、mp3、pcm。 默认：wav</value>
        [JsonConverter(typeof(EnumClassConverter<AudioFormatEnum>))]
        public class AudioFormatEnum
        {
            /// <summary>
            /// Enum WAV for value: wav
            /// </summary>
            public static readonly AudioFormatEnum WAV = new AudioFormatEnum("wav");

            /// <summary>
            /// Enum MP3 for value: mp3
            /// </summary>
            public static readonly AudioFormatEnum MP3 = new AudioFormatEnum("mp3");

            /// <summary>
            /// Enum PCM for value: pcm
            /// </summary>
            public static readonly AudioFormatEnum PCM = new AudioFormatEnum("pcm");

            private static readonly Dictionary<string, AudioFormatEnum> StaticFields =
            new Dictionary<string, AudioFormatEnum>()
            {
                { "wav", WAV },
                { "mp3", MP3 },
                { "pcm", PCM },
            };

            private string _value;

            public AudioFormatEnum()
            {

            }

            public AudioFormatEnum(string value)
            {
                _value = value;
            }

            public static AudioFormatEnum FromValue(string value)
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

                if (this.Equals(obj as AudioFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AudioFormatEnum a, AudioFormatEnum b)
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

            public static bool operator !=(AudioFormatEnum a, AudioFormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 采样率：16000、8000 默认：8000
        /// </summary>
        /// <value>采样率：16000、8000 默认：8000</value>
        [JsonConverter(typeof(EnumClassConverter<SampleRateEnum>))]
        public class SampleRateEnum
        {
            /// <summary>
            /// Enum _16000 for value: 16000
            /// </summary>
            public static readonly SampleRateEnum _16000 = new SampleRateEnum("16000");

            /// <summary>
            /// Enum _8000 for value: 8000
            /// </summary>
            public static readonly SampleRateEnum _8000 = new SampleRateEnum("8000");

            private static readonly Dictionary<string, SampleRateEnum> StaticFields =
            new Dictionary<string, SampleRateEnum>()
            {
                { "16000", _16000 },
                { "8000", _8000 },
            };

            private string _value;

            public SampleRateEnum()
            {

            }

            public SampleRateEnum(string value)
            {
                _value = value;
            }

            public static SampleRateEnum FromValue(string value)
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

                if (this.Equals(obj as SampleRateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SampleRateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SampleRateEnum a, SampleRateEnum b)
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

            public static bool operator !=(SampleRateEnum a, SampleRateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 语音合成特征字符串，组成形式为{language}_{speaker}_{domain}，即“语种_人员标识_领域”。发音人分为普通发音人和精品发音人。  普通发音人每100字计一次调用，取值范围如下：   chinese_xiaoqi_common  小琪，标准女声发音人。  chinese_xiaoyu_common  小宇，标准男声发音人。  chinese_xiaoyan_common  小燕，温柔女声发音人。  chinese_xiaowang_common  小王，童声发音人。  chinese_xiaowen_common   小雯，柔美女声发音人。  chinese_xiaojing_common 小婧，俏皮女声发音人。  chinese_xiaosong_common  小宋，激昂男声发音人。  chinese_xiaoxia_common   小夏，热情女声发音人。  chinese_xiaodai_common   小呆，呆萌童声发音人。  chinese_xiaoqian_common  小倩，成熟女声发音人。  english_cameal_common    cameal，柔美女声英文发音人。   精品发音人每50字计一次调用，区域仅支持cn-north-4，cn-east-3，暂时不支持音高调节，取值范围如下：  chinese_huaxiaoxia_common  华小夏，热情女声发音人。  chinese_huaxiaogang_common  华晓刚，利落男声发音人。  chinese_huaxiaolu_common  华小璐，知性女声发音人。  chinese_huaxiaoshu_common  华小舒，舒缓女声发音人。  chinese_huaxiaowei_common  华小唯，嗲柔女声发音人。  chinese_huaxiaoliang_common  华小靓，嘹亮女声发音人。  chinese_huaxiaodong_common  华晓东，成熟男声发音人。  chinese_huaxiaoyan_common  华小颜，严厉女声发音人。  chinese_huaxiaoxuan_common  华小萱，台湾女声发音人。  chinese_huaxiaowen_common  华小雯，柔美女声发音人。  chinese_huaxiaoyang_common  华晓阳，朝气男声发音人。  chinese_huaxiaomin_common  华小闽，闽南女声发音人。  chinese_huanvxia_literature 华女侠，武侠女生发音人，只支持16k的采样率。  chinese_huaxiaoxuan_literature 华晓悬，悬疑男声发音人，只支持16k的采样率。  chinese_huaxiaomei_common 华小美，温柔女声发音人。  chinese_huaxiaofei_common 华小飞，朝气男声发音人。  chinese_huaxiaolong_common 华小龙，朝气男声发音人。  chinese_huaxiaorui_common 华小蕊，知性女声发音人。  chinese_huaxiaoru_common 华小汝，柔美女声发音人(中英混)。  chinese_huaxiaohan_common 华小涵，知性女声发音人(中英混)。  chinese_huaxiaoning_common 华小宁，沉稳男声发言人(中英混)。  chinese_huaxiaozhen_common 华小珍，温柔女声发音人(中英混)。  chinese_huaxiaoman_common 华小曼，温柔女声发音人(中英混)。  chinese_huaxiaofang_common 华小芳，朝气女声发音人(中英混)。  chinese_huaxiaojun_common 华小筠，成熟女声发音人(中英混)。  english_alvin_common alvin，成熟男声纯英文发音人。  english_amy_common amy amy，成熟女声纯英文发音人。  默认：chinese_xiaoyan_common
        /// </summary>
        /// <value>语音合成特征字符串，组成形式为{language}_{speaker}_{domain}，即“语种_人员标识_领域”。发音人分为普通发音人和精品发音人。  普通发音人每100字计一次调用，取值范围如下：   chinese_xiaoqi_common  小琪，标准女声发音人。  chinese_xiaoyu_common  小宇，标准男声发音人。  chinese_xiaoyan_common  小燕，温柔女声发音人。  chinese_xiaowang_common  小王，童声发音人。  chinese_xiaowen_common   小雯，柔美女声发音人。  chinese_xiaojing_common 小婧，俏皮女声发音人。  chinese_xiaosong_common  小宋，激昂男声发音人。  chinese_xiaoxia_common   小夏，热情女声发音人。  chinese_xiaodai_common   小呆，呆萌童声发音人。  chinese_xiaoqian_common  小倩，成熟女声发音人。  english_cameal_common    cameal，柔美女声英文发音人。   精品发音人每50字计一次调用，区域仅支持cn-north-4，cn-east-3，暂时不支持音高调节，取值范围如下：  chinese_huaxiaoxia_common  华小夏，热情女声发音人。  chinese_huaxiaogang_common  华晓刚，利落男声发音人。  chinese_huaxiaolu_common  华小璐，知性女声发音人。  chinese_huaxiaoshu_common  华小舒，舒缓女声发音人。  chinese_huaxiaowei_common  华小唯，嗲柔女声发音人。  chinese_huaxiaoliang_common  华小靓，嘹亮女声发音人。  chinese_huaxiaodong_common  华晓东，成熟男声发音人。  chinese_huaxiaoyan_common  华小颜，严厉女声发音人。  chinese_huaxiaoxuan_common  华小萱，台湾女声发音人。  chinese_huaxiaowen_common  华小雯，柔美女声发音人。  chinese_huaxiaoyang_common  华晓阳，朝气男声发音人。  chinese_huaxiaomin_common  华小闽，闽南女声发音人。  chinese_huanvxia_literature 华女侠，武侠女生发音人，只支持16k的采样率。  chinese_huaxiaoxuan_literature 华晓悬，悬疑男声发音人，只支持16k的采样率。  chinese_huaxiaomei_common 华小美，温柔女声发音人。  chinese_huaxiaofei_common 华小飞，朝气男声发音人。  chinese_huaxiaolong_common 华小龙，朝气男声发音人。  chinese_huaxiaorui_common 华小蕊，知性女声发音人。  chinese_huaxiaoru_common 华小汝，柔美女声发音人(中英混)。  chinese_huaxiaohan_common 华小涵，知性女声发音人(中英混)。  chinese_huaxiaoning_common 华小宁，沉稳男声发言人(中英混)。  chinese_huaxiaozhen_common 华小珍，温柔女声发音人(中英混)。  chinese_huaxiaoman_common 华小曼，温柔女声发音人(中英混)。  chinese_huaxiaofang_common 华小芳，朝气女声发音人(中英混)。  chinese_huaxiaojun_common 华小筠，成熟女声发音人(中英混)。  english_alvin_common alvin，成熟男声纯英文发音人。  english_amy_common amy amy，成熟女声纯英文发音人。  默认：chinese_xiaoyan_common</value>
        [JsonConverter(typeof(EnumClassConverter<PropertyEnum>))]
        public class PropertyEnum
        {
            /// <summary>
            /// Enum CHINESE_XIAOQI_COMMON for value: chinese_xiaoqi_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAOQI_COMMON = new PropertyEnum("chinese_xiaoqi_common");

            /// <summary>
            /// Enum CHINESE_XIAOYU_COMMON for value: chinese_xiaoyu_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAOYU_COMMON = new PropertyEnum("chinese_xiaoyu_common");

            /// <summary>
            /// Enum CHINESE_XIAOYAN_COMMON for value: chinese_xiaoyan_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAOYAN_COMMON = new PropertyEnum("chinese_xiaoyan_common");

            /// <summary>
            /// Enum CHINESE_XIAOXIA_COMMON for value: chinese_xiaoxia_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAOXIA_COMMON = new PropertyEnum("chinese_xiaoxia_common");

            /// <summary>
            /// Enum CHINESE_XIAODAI_COMMON for value: chinese_xiaodai_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAODAI_COMMON = new PropertyEnum("chinese_xiaodai_common");

            /// <summary>
            /// Enum CHINESE_XIAOQIAN_COMMON for value: chinese_xiaoqian_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAOQIAN_COMMON = new PropertyEnum("chinese_xiaoqian_common");

            /// <summary>
            /// Enum CHINESE_XIAOWANG_COMMON for value: chinese_xiaowang_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAOWANG_COMMON = new PropertyEnum("chinese_xiaowang_common");

            /// <summary>
            /// Enum CHINESE_XIAOWEN_COMMON for value: chinese_xiaowen_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAOWEN_COMMON = new PropertyEnum("chinese_xiaowen_common");

            /// <summary>
            /// Enum CHINESE_XIAOJING_COMMON for value: chinese_xiaojing_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAOJING_COMMON = new PropertyEnum("chinese_xiaojing_common");

            /// <summary>
            /// Enum CHINESE_XIAOSONG_COMMON for value: chinese_xiaosong_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_XIAOSONG_COMMON = new PropertyEnum("chinese_xiaosong_common");

            /// <summary>
            /// Enum ENGLISH_CAMEAL_COMMON for value: english_cameal_common
            /// </summary>
            public static readonly PropertyEnum ENGLISH_CAMEAL_COMMON = new PropertyEnum("english_cameal_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOXIA_COMMON for value: chinese_huaxiaoxia_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOXIA_COMMON = new PropertyEnum("chinese_huaxiaoxia_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOGANG_COMMON for value: chinese_huaxiaogang_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOGANG_COMMON = new PropertyEnum("chinese_huaxiaogang_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOLU_COMMON for value: chinese_huaxiaolu_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOLU_COMMON = new PropertyEnum("chinese_huaxiaolu_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOSHU_COMMON for value: chinese_huaxiaoshu_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOSHU_COMMON = new PropertyEnum("chinese_huaxiaoshu_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOWEI_COMMON for value: chinese_huaxiaowei_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOWEI_COMMON = new PropertyEnum("chinese_huaxiaowei_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOLIANG_COMMON for value: chinese_huaxiaoliang_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOLIANG_COMMON = new PropertyEnum("chinese_huaxiaoliang_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAODONG_COMMON for value: chinese_huaxiaodong_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAODONG_COMMON = new PropertyEnum("chinese_huaxiaodong_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOYAN_COMMON for value: chinese_huaxiaoyan_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOYAN_COMMON = new PropertyEnum("chinese_huaxiaoyan_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOXUAN_COMMON for value: chinese_huaxiaoxuan_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOXUAN_COMMON = new PropertyEnum("chinese_huaxiaoxuan_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOWEN_COMMON for value: chinese_huaxiaowen_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOWEN_COMMON = new PropertyEnum("chinese_huaxiaowen_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOYANG_COMMON for value: chinese_huaxiaoyang_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOYANG_COMMON = new PropertyEnum("chinese_huaxiaoyang_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOMIN_COMMON for value: chinese_huaxiaomin_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOMIN_COMMON = new PropertyEnum("chinese_huaxiaomin_common");

            /// <summary>
            /// Enum CHINESE_HUANVXIA_LITERATURE for value: chinese_huanvxia_literature
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUANVXIA_LITERATURE = new PropertyEnum("chinese_huanvxia_literature");

            /// <summary>
            /// Enum CHINESE_HUAXIAOXUAN_LITERATURE for value: chinese_huaxiaoxuan_literature
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOXUAN_LITERATURE = new PropertyEnum("chinese_huaxiaoxuan_literature");

            /// <summary>
            /// Enum CHINESE_HUAXIAOMEI_COMMON for value: chinese_huaxiaomei_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOMEI_COMMON = new PropertyEnum("chinese_huaxiaomei_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOFEI_COMMON for value: chinese_huaxiaofei_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOFEI_COMMON = new PropertyEnum("chinese_huaxiaofei_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOLONG_COMMON for value: chinese_huaxiaolong_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOLONG_COMMON = new PropertyEnum("chinese_huaxiaolong_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAORUI_COMMON for value: chinese_huaxiaorui_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAORUI_COMMON = new PropertyEnum("chinese_huaxiaorui_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAORU_COMMON for value: chinese_huaxiaoru_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAORU_COMMON = new PropertyEnum("chinese_huaxiaoru_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOHAN_COMMON for value: chinese_huaxiaohan_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOHAN_COMMON = new PropertyEnum("chinese_huaxiaohan_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAONING_COMMON for value: chinese_huaxiaoning_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAONING_COMMON = new PropertyEnum("chinese_huaxiaoning_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOZHEN_COMMON for value: chinese_huaxiaozhen_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOZHEN_COMMON = new PropertyEnum("chinese_huaxiaozhen_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOMAN_COMMON for value: chinese_huaxiaoman_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOMAN_COMMON = new PropertyEnum("chinese_huaxiaoman_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOFANG_COMMON for value: chinese_huaxiaofang_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOFANG_COMMON = new PropertyEnum("chinese_huaxiaofang_common");

            /// <summary>
            /// Enum CHINESE_HUAXIAOJUN_COMMON for value: chinese_huaxiaojun_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_HUAXIAOJUN_COMMON = new PropertyEnum("chinese_huaxiaojun_common");

            /// <summary>
            /// Enum ENGLISH_ALVIN_COMMON for value: english_alvin_common
            /// </summary>
            public static readonly PropertyEnum ENGLISH_ALVIN_COMMON = new PropertyEnum("english_alvin_common");

            /// <summary>
            /// Enum ENGLISH_AMY_COMMON for value: english_amy_common
            /// </summary>
            public static readonly PropertyEnum ENGLISH_AMY_COMMON = new PropertyEnum("english_amy_common");

            private static readonly Dictionary<string, PropertyEnum> StaticFields =
            new Dictionary<string, PropertyEnum>()
            {
                { "chinese_xiaoqi_common", CHINESE_XIAOQI_COMMON },
                { "chinese_xiaoyu_common", CHINESE_XIAOYU_COMMON },
                { "chinese_xiaoyan_common", CHINESE_XIAOYAN_COMMON },
                { "chinese_xiaoxia_common", CHINESE_XIAOXIA_COMMON },
                { "chinese_xiaodai_common", CHINESE_XIAODAI_COMMON },
                { "chinese_xiaoqian_common", CHINESE_XIAOQIAN_COMMON },
                { "chinese_xiaowang_common", CHINESE_XIAOWANG_COMMON },
                { "chinese_xiaowen_common", CHINESE_XIAOWEN_COMMON },
                { "chinese_xiaojing_common", CHINESE_XIAOJING_COMMON },
                { "chinese_xiaosong_common", CHINESE_XIAOSONG_COMMON },
                { "english_cameal_common", ENGLISH_CAMEAL_COMMON },
                { "chinese_huaxiaoxia_common", CHINESE_HUAXIAOXIA_COMMON },
                { "chinese_huaxiaogang_common", CHINESE_HUAXIAOGANG_COMMON },
                { "chinese_huaxiaolu_common", CHINESE_HUAXIAOLU_COMMON },
                { "chinese_huaxiaoshu_common", CHINESE_HUAXIAOSHU_COMMON },
                { "chinese_huaxiaowei_common", CHINESE_HUAXIAOWEI_COMMON },
                { "chinese_huaxiaoliang_common", CHINESE_HUAXIAOLIANG_COMMON },
                { "chinese_huaxiaodong_common", CHINESE_HUAXIAODONG_COMMON },
                { "chinese_huaxiaoyan_common", CHINESE_HUAXIAOYAN_COMMON },
                { "chinese_huaxiaoxuan_common", CHINESE_HUAXIAOXUAN_COMMON },
                { "chinese_huaxiaowen_common", CHINESE_HUAXIAOWEN_COMMON },
                { "chinese_huaxiaoyang_common", CHINESE_HUAXIAOYANG_COMMON },
                { "chinese_huaxiaomin_common", CHINESE_HUAXIAOMIN_COMMON },
                { "chinese_huanvxia_literature", CHINESE_HUANVXIA_LITERATURE },
                { "chinese_huaxiaoxuan_literature", CHINESE_HUAXIAOXUAN_LITERATURE },
                { "chinese_huaxiaomei_common", CHINESE_HUAXIAOMEI_COMMON },
                { "chinese_huaxiaofei_common", CHINESE_HUAXIAOFEI_COMMON },
                { "chinese_huaxiaolong_common", CHINESE_HUAXIAOLONG_COMMON },
                { "chinese_huaxiaorui_common", CHINESE_HUAXIAORUI_COMMON },
                { "chinese_huaxiaoru_common", CHINESE_HUAXIAORU_COMMON },
                { "chinese_huaxiaohan_common", CHINESE_HUAXIAOHAN_COMMON },
                { "chinese_huaxiaoning_common", CHINESE_HUAXIAONING_COMMON },
                { "chinese_huaxiaozhen_common", CHINESE_HUAXIAOZHEN_COMMON },
                { "chinese_huaxiaoman_common", CHINESE_HUAXIAOMAN_COMMON },
                { "chinese_huaxiaofang_common", CHINESE_HUAXIAOFANG_COMMON },
                { "chinese_huaxiaojun_common", CHINESE_HUAXIAOJUN_COMMON },
                { "english_alvin_common", ENGLISH_ALVIN_COMMON },
                { "english_amy_common", ENGLISH_AMY_COMMON },
            };

            private string _value;

            public PropertyEnum()
            {

            }

            public PropertyEnum(string value)
            {
                _value = value;
            }

            public static PropertyEnum FromValue(string value)
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

                if (this.Equals(obj as PropertyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PropertyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PropertyEnum a, PropertyEnum b)
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

            public static bool operator !=(PropertyEnum a, PropertyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语音格式头：wav、mp3、pcm。 默认：wav
        /// </summary>
        [JsonProperty("audio_format", NullValueHandling = NullValueHandling.Ignore)]
        public AudioFormatEnum AudioFormat { get; set; }
        /// <summary>
        /// 采样率：16000、8000 默认：8000
        /// </summary>
        [JsonProperty("sample_rate", NullValueHandling = NullValueHandling.Ignore)]
        public SampleRateEnum SampleRate { get; set; }
        /// <summary>
        /// 语音合成特征字符串，组成形式为{language}_{speaker}_{domain}，即“语种_人员标识_领域”。发音人分为普通发音人和精品发音人。  普通发音人每100字计一次调用，取值范围如下：   chinese_xiaoqi_common  小琪，标准女声发音人。  chinese_xiaoyu_common  小宇，标准男声发音人。  chinese_xiaoyan_common  小燕，温柔女声发音人。  chinese_xiaowang_common  小王，童声发音人。  chinese_xiaowen_common   小雯，柔美女声发音人。  chinese_xiaojing_common 小婧，俏皮女声发音人。  chinese_xiaosong_common  小宋，激昂男声发音人。  chinese_xiaoxia_common   小夏，热情女声发音人。  chinese_xiaodai_common   小呆，呆萌童声发音人。  chinese_xiaoqian_common  小倩，成熟女声发音人。  english_cameal_common    cameal，柔美女声英文发音人。   精品发音人每50字计一次调用，区域仅支持cn-north-4，cn-east-3，暂时不支持音高调节，取值范围如下：  chinese_huaxiaoxia_common  华小夏，热情女声发音人。  chinese_huaxiaogang_common  华晓刚，利落男声发音人。  chinese_huaxiaolu_common  华小璐，知性女声发音人。  chinese_huaxiaoshu_common  华小舒，舒缓女声发音人。  chinese_huaxiaowei_common  华小唯，嗲柔女声发音人。  chinese_huaxiaoliang_common  华小靓，嘹亮女声发音人。  chinese_huaxiaodong_common  华晓东，成熟男声发音人。  chinese_huaxiaoyan_common  华小颜，严厉女声发音人。  chinese_huaxiaoxuan_common  华小萱，台湾女声发音人。  chinese_huaxiaowen_common  华小雯，柔美女声发音人。  chinese_huaxiaoyang_common  华晓阳，朝气男声发音人。  chinese_huaxiaomin_common  华小闽，闽南女声发音人。  chinese_huanvxia_literature 华女侠，武侠女生发音人，只支持16k的采样率。  chinese_huaxiaoxuan_literature 华晓悬，悬疑男声发音人，只支持16k的采样率。  chinese_huaxiaomei_common 华小美，温柔女声发音人。  chinese_huaxiaofei_common 华小飞，朝气男声发音人。  chinese_huaxiaolong_common 华小龙，朝气男声发音人。  chinese_huaxiaorui_common 华小蕊，知性女声发音人。  chinese_huaxiaoru_common 华小汝，柔美女声发音人(中英混)。  chinese_huaxiaohan_common 华小涵，知性女声发音人(中英混)。  chinese_huaxiaoning_common 华小宁，沉稳男声发言人(中英混)。  chinese_huaxiaozhen_common 华小珍，温柔女声发音人(中英混)。  chinese_huaxiaoman_common 华小曼，温柔女声发音人(中英混)。  chinese_huaxiaofang_common 华小芳，朝气女声发音人(中英混)。  chinese_huaxiaojun_common 华小筠，成熟女声发音人(中英混)。  english_alvin_common alvin，成熟男声纯英文发音人。  english_amy_common amy amy，成熟女声纯英文发音人。  默认：chinese_xiaoyan_common
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public PropertyEnum Property { get; set; }
        /// <summary>
        /// 语速。 取值范围：[-500,500]  默认值：0
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Speed { get; set; }

        /// <summary>
        /// 音高。 取值范围： [-500,500]  默认值：0
        /// </summary>
        [JsonProperty("pitch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pitch { get; set; }

        /// <summary>
        /// 音量。 取值范围：[0, 100]  默认值：50
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public int? Volume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TtsConfig {\n");
            sb.Append("  audioFormat: ").Append(AudioFormat).Append("\n");
            sb.Append("  sampleRate: ").Append(SampleRate).Append("\n");
            sb.Append("  property: ").Append(Property).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  pitch: ").Append(Pitch).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TtsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TtsConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AudioFormat == input.AudioFormat ||
                    (this.AudioFormat != null &&
                    this.AudioFormat.Equals(input.AudioFormat))
                ) && 
                (
                    this.SampleRate == input.SampleRate ||
                    (this.SampleRate != null &&
                    this.SampleRate.Equals(input.SampleRate))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.Speed == input.Speed ||
                    (this.Speed != null &&
                    this.Speed.Equals(input.Speed))
                ) && 
                (
                    this.Pitch == input.Pitch ||
                    (this.Pitch != null &&
                    this.Pitch.Equals(input.Pitch))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
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
                if (this.AudioFormat != null)
                    hashCode = hashCode * 59 + this.AudioFormat.GetHashCode();
                if (this.SampleRate != null)
                    hashCode = hashCode * 59 + this.SampleRate.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.Speed != null)
                    hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.Pitch != null)
                    hashCode = hashCode * 59 + this.Pitch.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                return hashCode;
            }
        }
    }
}
