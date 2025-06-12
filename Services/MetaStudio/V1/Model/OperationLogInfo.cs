using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 操作日志。
    /// </summary>
    public class OperationLogInfo 
    {
        /// <summary>
        /// 命令执行结果。 * USER_CREATE_JOD：用户开始分身数字人定制 * USER_VERIFYING_SUBMITTED：用户提交审核 * SYSTEM_VERIFY_FAILED：自动审核失败 * ADMIN_UPDATE_BEAUTY_LEVEL：管理员更新美白等级 * SYSTEM_VERIFY_SUCCESS：自动审核成功 * ADMIN_VERIFY_SUCCESS：人工审核通过 * ADMIN_VERIFY_FAILED：人工审核不通过 * SYSTEM_TRAIN_DATA_PREPROCESSING：训练数据预处理中 * SYSTEM_TRAIN_DATA_PREPROCESS_FAILED：训练数据预处理失败 * SYSTEM_TRAIN_DATA_PREPROCESS_SUCCESS：训练数据预处理成功 * SYSTEM_ACTION_GENERATE_DATA_PREPROCESSING：动作编排原子动作生成中 * SYSTEM_ACTION_GENERATE_DATA_SUCCESS：动作编排原子动作生成成功 * SYSTEM_ACTION_GENERATE_ORI_SUCCESS：动作编排资产数据生成成功 * SYSTEM_ACTION_GENERATE_DATA_FAILED：动作编排原子动作生成失败 * SYSTEM_ACTION_GENERATE_ORI_FAILED：动作编排资产数据生成失败 * SYSTEM_ACTION_GENERATE_ORI_PREPROCESSING：动作编排资产数据生成中 * SYSTEM_TRAINING：开始训练 * ADMIN_STOP_TRAINING_DATA_PREPROCESS：人工中止训练 * ADMIN_STOP_BEAUTY_PREPROCESS：人工中止美白 * ADMIN_STOP_INFERENCE_DATA_PREPROCESS：人工中止推理预处理 * ADMIN_STOP_TRAIN：人工终止训练 * SYSTEM_TRAIN_FAILED：训练失败 * SYSTEM_TRAIN_SUCCESS：训练成功 * SYSTEM_INFERENCE_DATA_PREPROCESSING：推理数据预处理中 * SYSTEM_INFERENCE_DATA_PREPROCESS_FAILED：推理数据预处理失败 * SYSTEM_INFERENCE_DATA_PREPROCESS_SUCCESS：推理数据预处理成功 * SYSTEM_JOB_SUCCESS：任务处理完成 * ADMIN_MASK_UPLOADED：遮罩文件上传完成（已废弃） * ADMIN_UPDATE_VIDEO：管理员更换视频 * ADMIN_UPDATE_ACTION_VIDEO：管理员更换动作编排视频 * ADMIN_RESET：管理员一键重置 * ADMIN_ACCEPT：管理员通过 * USER_REPAIR：用户修复 * SYSTEM_UPDATE_COVER：更换封面 * ADMIN_SET_SILENCE_REPEAT_NUM：管理员设置静默轮数 * SYSTEM_MARKABLE_VIDEO：标记视频生成任务 * SYSTEM_MASK_VERIFY_VIDEO：校验视频生成任务 * SYSTEM_MASK_VERIFY_VIDEO_SUCCESS：校验视频生成成功 * SYSTEM_MASK_VERIFY_VIDEO_FAILED：校验视频生成失败 * SYSTEM_MARKABLE_VIDEO_SUCCESS：标记视频生成成功 * SYSTEM_BEAUTY_PREPROCESSING：美白处理中 * SYSTEM_BEAUTY_PREPROCESS_FAILED：美白处理失败 * ADMIN_CONFIRM_ACTION：管理员确认动作 * ADMIN_STOP_ACTION_GENERATE_DATA_PREPROCESS：人工中止原子动作生成 * ADMIN_STOP_ACTION_GENERATE_ORI_PREPROCESS：人工中止动作编排 * SYSTEM_BEAUTY_PREPROCESS_SUCCESS：美白视频训练预处理成功 * SYSTEM_COMPILE_FAILED：转编译失败 * SYSTEM_COMPILE_SUCCESS：转编译成功 * SYSTEM_MARKABLE_VIDEO_FAILED：标记视频生成失败 * ADMIN_UPDATE_COMPILE：管理员更新转编译配置 * ADMIN_UPDATE_INFERENCE_DATA_PROCESS_VIDEO：管理员更新推理预处理时间段信息 * SYSTEM_EXECUTE_COMPILE：执行转编译 * SYSTEM_EXECUTE_BEAUTY：执行美白处理 * SYSTEM_MASK_VIDEO_AND_ACTION_TIME_SUCCESS：自动标记成功 * SYSTEM_MASK_VIDEO_AND_ACTION_TIME_FAILED：自动标记失败 * USER_UPDATE_VIDEO：用户更换视频 * ADMIN_UPDATE_GENERAL_CONFIG：管理员更新通用配置 * ADMIN_MASK_ACTION_TIME：管理员标记 * STOP_COMPILE：人工中止转编译
        /// </summary>
        /// <value>命令执行结果。 * USER_CREATE_JOD：用户开始分身数字人定制 * USER_VERIFYING_SUBMITTED：用户提交审核 * SYSTEM_VERIFY_FAILED：自动审核失败 * ADMIN_UPDATE_BEAUTY_LEVEL：管理员更新美白等级 * SYSTEM_VERIFY_SUCCESS：自动审核成功 * ADMIN_VERIFY_SUCCESS：人工审核通过 * ADMIN_VERIFY_FAILED：人工审核不通过 * SYSTEM_TRAIN_DATA_PREPROCESSING：训练数据预处理中 * SYSTEM_TRAIN_DATA_PREPROCESS_FAILED：训练数据预处理失败 * SYSTEM_TRAIN_DATA_PREPROCESS_SUCCESS：训练数据预处理成功 * SYSTEM_ACTION_GENERATE_DATA_PREPROCESSING：动作编排原子动作生成中 * SYSTEM_ACTION_GENERATE_DATA_SUCCESS：动作编排原子动作生成成功 * SYSTEM_ACTION_GENERATE_ORI_SUCCESS：动作编排资产数据生成成功 * SYSTEM_ACTION_GENERATE_DATA_FAILED：动作编排原子动作生成失败 * SYSTEM_ACTION_GENERATE_ORI_FAILED：动作编排资产数据生成失败 * SYSTEM_ACTION_GENERATE_ORI_PREPROCESSING：动作编排资产数据生成中 * SYSTEM_TRAINING：开始训练 * ADMIN_STOP_TRAINING_DATA_PREPROCESS：人工中止训练 * ADMIN_STOP_BEAUTY_PREPROCESS：人工中止美白 * ADMIN_STOP_INFERENCE_DATA_PREPROCESS：人工中止推理预处理 * ADMIN_STOP_TRAIN：人工终止训练 * SYSTEM_TRAIN_FAILED：训练失败 * SYSTEM_TRAIN_SUCCESS：训练成功 * SYSTEM_INFERENCE_DATA_PREPROCESSING：推理数据预处理中 * SYSTEM_INFERENCE_DATA_PREPROCESS_FAILED：推理数据预处理失败 * SYSTEM_INFERENCE_DATA_PREPROCESS_SUCCESS：推理数据预处理成功 * SYSTEM_JOB_SUCCESS：任务处理完成 * ADMIN_MASK_UPLOADED：遮罩文件上传完成（已废弃） * ADMIN_UPDATE_VIDEO：管理员更换视频 * ADMIN_UPDATE_ACTION_VIDEO：管理员更换动作编排视频 * ADMIN_RESET：管理员一键重置 * ADMIN_ACCEPT：管理员通过 * USER_REPAIR：用户修复 * SYSTEM_UPDATE_COVER：更换封面 * ADMIN_SET_SILENCE_REPEAT_NUM：管理员设置静默轮数 * SYSTEM_MARKABLE_VIDEO：标记视频生成任务 * SYSTEM_MASK_VERIFY_VIDEO：校验视频生成任务 * SYSTEM_MASK_VERIFY_VIDEO_SUCCESS：校验视频生成成功 * SYSTEM_MASK_VERIFY_VIDEO_FAILED：校验视频生成失败 * SYSTEM_MARKABLE_VIDEO_SUCCESS：标记视频生成成功 * SYSTEM_BEAUTY_PREPROCESSING：美白处理中 * SYSTEM_BEAUTY_PREPROCESS_FAILED：美白处理失败 * ADMIN_CONFIRM_ACTION：管理员确认动作 * ADMIN_STOP_ACTION_GENERATE_DATA_PREPROCESS：人工中止原子动作生成 * ADMIN_STOP_ACTION_GENERATE_ORI_PREPROCESS：人工中止动作编排 * SYSTEM_BEAUTY_PREPROCESS_SUCCESS：美白视频训练预处理成功 * SYSTEM_COMPILE_FAILED：转编译失败 * SYSTEM_COMPILE_SUCCESS：转编译成功 * SYSTEM_MARKABLE_VIDEO_FAILED：标记视频生成失败 * ADMIN_UPDATE_COMPILE：管理员更新转编译配置 * ADMIN_UPDATE_INFERENCE_DATA_PROCESS_VIDEO：管理员更新推理预处理时间段信息 * SYSTEM_EXECUTE_COMPILE：执行转编译 * SYSTEM_EXECUTE_BEAUTY：执行美白处理 * SYSTEM_MASK_VIDEO_AND_ACTION_TIME_SUCCESS：自动标记成功 * SYSTEM_MASK_VIDEO_AND_ACTION_TIME_FAILED：自动标记失败 * USER_UPDATE_VIDEO：用户更换视频 * ADMIN_UPDATE_GENERAL_CONFIG：管理员更新通用配置 * ADMIN_MASK_ACTION_TIME：管理员标记 * STOP_COMPILE：人工中止转编译</value>
        [JsonConverter(typeof(EnumClassConverter<LogTypeEnum>))]
        public class LogTypeEnum
        {
            /// <summary>
            /// Enum USER_CREATE_JOD for value: USER_CREATE_JOD
            /// </summary>
            public static readonly LogTypeEnum USER_CREATE_JOD = new LogTypeEnum("USER_CREATE_JOD");

            /// <summary>
            /// Enum USER_VERIFYING_SUBMITTED for value: USER_VERIFYING_SUBMITTED
            /// </summary>
            public static readonly LogTypeEnum USER_VERIFYING_SUBMITTED = new LogTypeEnum("USER_VERIFYING_SUBMITTED");

            /// <summary>
            /// Enum SYSTEM_VERIFY_FAILED for value: SYSTEM_VERIFY_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_VERIFY_FAILED = new LogTypeEnum("SYSTEM_VERIFY_FAILED");

            /// <summary>
            /// Enum ADMIN_UPDATE_BEAUTY_LEVEL for value: ADMIN_UPDATE_BEAUTY_LEVEL
            /// </summary>
            public static readonly LogTypeEnum ADMIN_UPDATE_BEAUTY_LEVEL = new LogTypeEnum("ADMIN_UPDATE_BEAUTY_LEVEL");

            /// <summary>
            /// Enum SYSTEM_VERIFY_SUCCESS for value: SYSTEM_VERIFY_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_VERIFY_SUCCESS = new LogTypeEnum("SYSTEM_VERIFY_SUCCESS");

            /// <summary>
            /// Enum ADMIN_VERIFY_SUCCESS for value: ADMIN_VERIFY_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum ADMIN_VERIFY_SUCCESS = new LogTypeEnum("ADMIN_VERIFY_SUCCESS");

            /// <summary>
            /// Enum ADMIN_VERIFY_FAILED for value: ADMIN_VERIFY_FAILED
            /// </summary>
            public static readonly LogTypeEnum ADMIN_VERIFY_FAILED = new LogTypeEnum("ADMIN_VERIFY_FAILED");

            /// <summary>
            /// Enum SYSTEM_TRAIN_DATA_PREPROCESSING for value: SYSTEM_TRAIN_DATA_PREPROCESSING
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_TRAIN_DATA_PREPROCESSING = new LogTypeEnum("SYSTEM_TRAIN_DATA_PREPROCESSING");

            /// <summary>
            /// Enum SYSTEM_TRAIN_DATA_PREPROCESS_FAILED for value: SYSTEM_TRAIN_DATA_PREPROCESS_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_TRAIN_DATA_PREPROCESS_FAILED = new LogTypeEnum("SYSTEM_TRAIN_DATA_PREPROCESS_FAILED");

            /// <summary>
            /// Enum SYSTEM_TRAIN_DATA_PREPROCESS_SUCCESS for value: SYSTEM_TRAIN_DATA_PREPROCESS_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_TRAIN_DATA_PREPROCESS_SUCCESS = new LogTypeEnum("SYSTEM_TRAIN_DATA_PREPROCESS_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_ACTION_GENERATE_DATA_PREPROCESSING for value: SYSTEM_ACTION_GENERATE_DATA_PREPROCESSING
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_ACTION_GENERATE_DATA_PREPROCESSING = new LogTypeEnum("SYSTEM_ACTION_GENERATE_DATA_PREPROCESSING");

            /// <summary>
            /// Enum SYSTEM_ACTION_GENERATE_DATA_SUCCESS for value: SYSTEM_ACTION_GENERATE_DATA_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_ACTION_GENERATE_DATA_SUCCESS = new LogTypeEnum("SYSTEM_ACTION_GENERATE_DATA_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_ACTION_GENERATE_ORI_SUCCESS for value: SYSTEM_ACTION_GENERATE_ORI_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_ACTION_GENERATE_ORI_SUCCESS = new LogTypeEnum("SYSTEM_ACTION_GENERATE_ORI_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_ACTION_GENERATE_DATA_FAILED for value: SYSTEM_ACTION_GENERATE_DATA_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_ACTION_GENERATE_DATA_FAILED = new LogTypeEnum("SYSTEM_ACTION_GENERATE_DATA_FAILED");

            /// <summary>
            /// Enum SYSTEM_ACTION_GENERATE_ORI_FAILED for value: SYSTEM_ACTION_GENERATE_ORI_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_ACTION_GENERATE_ORI_FAILED = new LogTypeEnum("SYSTEM_ACTION_GENERATE_ORI_FAILED");

            /// <summary>
            /// Enum SYSTEM_ACTION_GENERATE_ORI_PREPROCESSING for value: SYSTEM_ACTION_GENERATE_ORI_PREPROCESSING
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_ACTION_GENERATE_ORI_PREPROCESSING = new LogTypeEnum("SYSTEM_ACTION_GENERATE_ORI_PREPROCESSING");

            /// <summary>
            /// Enum SYSTEM_TRAINING for value: SYSTEM_TRAINING
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_TRAINING = new LogTypeEnum("SYSTEM_TRAINING");

            /// <summary>
            /// Enum ADMIN_STOP_TRAINING_DATA_PREPROCESS for value: ADMIN_STOP_TRAINING_DATA_PREPROCESS
            /// </summary>
            public static readonly LogTypeEnum ADMIN_STOP_TRAINING_DATA_PREPROCESS = new LogTypeEnum("ADMIN_STOP_TRAINING_DATA_PREPROCESS");

            /// <summary>
            /// Enum ADMIN_STOP_BEAUTY_PREPROCESS for value: ADMIN_STOP_BEAUTY_PREPROCESS
            /// </summary>
            public static readonly LogTypeEnum ADMIN_STOP_BEAUTY_PREPROCESS = new LogTypeEnum("ADMIN_STOP_BEAUTY_PREPROCESS");

            /// <summary>
            /// Enum ADMIN_STOP_INFERENCE_DATA_PREPROCESS for value: ADMIN_STOP_INFERENCE_DATA_PREPROCESS
            /// </summary>
            public static readonly LogTypeEnum ADMIN_STOP_INFERENCE_DATA_PREPROCESS = new LogTypeEnum("ADMIN_STOP_INFERENCE_DATA_PREPROCESS");

            /// <summary>
            /// Enum ADMIN_STOP_TRAIN for value: ADMIN_STOP_TRAIN
            /// </summary>
            public static readonly LogTypeEnum ADMIN_STOP_TRAIN = new LogTypeEnum("ADMIN_STOP_TRAIN");

            /// <summary>
            /// Enum SYSTEM_TRAIN_FAILED for value: SYSTEM_TRAIN_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_TRAIN_FAILED = new LogTypeEnum("SYSTEM_TRAIN_FAILED");

            /// <summary>
            /// Enum SYSTEM_TRAIN_SUCCESS for value: SYSTEM_TRAIN_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_TRAIN_SUCCESS = new LogTypeEnum("SYSTEM_TRAIN_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_INFERENCE_DATA_PREPROCESSING for value: SYSTEM_INFERENCE_DATA_PREPROCESSING
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_INFERENCE_DATA_PREPROCESSING = new LogTypeEnum("SYSTEM_INFERENCE_DATA_PREPROCESSING");

            /// <summary>
            /// Enum SYSTEM_INFERENCE_DATA_PREPROCESS_FAILED for value: SYSTEM_INFERENCE_DATA_PREPROCESS_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_INFERENCE_DATA_PREPROCESS_FAILED = new LogTypeEnum("SYSTEM_INFERENCE_DATA_PREPROCESS_FAILED");

            /// <summary>
            /// Enum SYSTEM_INFERENCE_DATA_PREPROCESS_SUCCESS for value: SYSTEM_INFERENCE_DATA_PREPROCESS_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_INFERENCE_DATA_PREPROCESS_SUCCESS = new LogTypeEnum("SYSTEM_INFERENCE_DATA_PREPROCESS_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_JOB_SUCCESS for value: SYSTEM_JOB_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_JOB_SUCCESS = new LogTypeEnum("SYSTEM_JOB_SUCCESS");

            /// <summary>
            /// Enum ADMIN_MASK_UPLOADED for value: ADMIN_MASK_UPLOADED
            /// </summary>
            public static readonly LogTypeEnum ADMIN_MASK_UPLOADED = new LogTypeEnum("ADMIN_MASK_UPLOADED");

            /// <summary>
            /// Enum ADMIN_UPDATE_VIDEO for value: ADMIN_UPDATE_VIDEO
            /// </summary>
            public static readonly LogTypeEnum ADMIN_UPDATE_VIDEO = new LogTypeEnum("ADMIN_UPDATE_VIDEO");

            /// <summary>
            /// Enum ADMIN_UPDATE_ACTION_VIDEO for value: ADMIN_UPDATE_ACTION_VIDEO
            /// </summary>
            public static readonly LogTypeEnum ADMIN_UPDATE_ACTION_VIDEO = new LogTypeEnum("ADMIN_UPDATE_ACTION_VIDEO");

            /// <summary>
            /// Enum ADMIN_RESET for value: ADMIN_RESET
            /// </summary>
            public static readonly LogTypeEnum ADMIN_RESET = new LogTypeEnum("ADMIN_RESET");

            /// <summary>
            /// Enum ADMIN_ACCEPT for value: ADMIN_ACCEPT
            /// </summary>
            public static readonly LogTypeEnum ADMIN_ACCEPT = new LogTypeEnum("ADMIN_ACCEPT");

            /// <summary>
            /// Enum USER_REPAIR for value: USER_REPAIR
            /// </summary>
            public static readonly LogTypeEnum USER_REPAIR = new LogTypeEnum("USER_REPAIR");

            /// <summary>
            /// Enum SYSTEM_UPDATE_COVER for value: SYSTEM_UPDATE_COVER
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_UPDATE_COVER = new LogTypeEnum("SYSTEM_UPDATE_COVER");

            /// <summary>
            /// Enum ADMIN_SET_SILENCE_REPEAT_NUM for value: ADMIN_SET_SILENCE_REPEAT_NUM
            /// </summary>
            public static readonly LogTypeEnum ADMIN_SET_SILENCE_REPEAT_NUM = new LogTypeEnum("ADMIN_SET_SILENCE_REPEAT_NUM");

            /// <summary>
            /// Enum SYSTEM_MARKABLE_VIDEO for value: SYSTEM_MARKABLE_VIDEO
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_MARKABLE_VIDEO = new LogTypeEnum("SYSTEM_MARKABLE_VIDEO");

            /// <summary>
            /// Enum SYSTEM_MASK_VERIFY_VIDEO for value: SYSTEM_MASK_VERIFY_VIDEO
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_MASK_VERIFY_VIDEO = new LogTypeEnum("SYSTEM_MASK_VERIFY_VIDEO");

            /// <summary>
            /// Enum SYSTEM_MASK_VERIFY_VIDEO_SUCCESS for value: SYSTEM_MASK_VERIFY_VIDEO_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_MASK_VERIFY_VIDEO_SUCCESS = new LogTypeEnum("SYSTEM_MASK_VERIFY_VIDEO_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_MASK_VERIFY_VIDEO_FAILED for value: SYSTEM_MASK_VERIFY_VIDEO_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_MASK_VERIFY_VIDEO_FAILED = new LogTypeEnum("SYSTEM_MASK_VERIFY_VIDEO_FAILED");

            /// <summary>
            /// Enum SYSTEM_MARKABLE_VIDEO_SUCCESS for value: SYSTEM_MARKABLE_VIDEO_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_MARKABLE_VIDEO_SUCCESS = new LogTypeEnum("SYSTEM_MARKABLE_VIDEO_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_BEAUTY_PREPROCESSING for value: SYSTEM_BEAUTY_PREPROCESSING
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_BEAUTY_PREPROCESSING = new LogTypeEnum("SYSTEM_BEAUTY_PREPROCESSING");

            /// <summary>
            /// Enum SYSTEM_BEAUTY_PREPROCESS_FAILED for value: SYSTEM_BEAUTY_PREPROCESS_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_BEAUTY_PREPROCESS_FAILED = new LogTypeEnum("SYSTEM_BEAUTY_PREPROCESS_FAILED");

            /// <summary>
            /// Enum ADMIN_CONFIRM_ACTION for value: ADMIN_CONFIRM_ACTION
            /// </summary>
            public static readonly LogTypeEnum ADMIN_CONFIRM_ACTION = new LogTypeEnum("ADMIN_CONFIRM_ACTION");

            /// <summary>
            /// Enum ADMIN_STOP_ACTION_GENERATE_DATA_PREPROCESS for value: ADMIN_STOP_ACTION_GENERATE_DATA_PREPROCESS
            /// </summary>
            public static readonly LogTypeEnum ADMIN_STOP_ACTION_GENERATE_DATA_PREPROCESS = new LogTypeEnum("ADMIN_STOP_ACTION_GENERATE_DATA_PREPROCESS");

            /// <summary>
            /// Enum ADMIN_STOP_ACTION_GENERATE_ORI_PREPROCESS for value: ADMIN_STOP_ACTION_GENERATE_ORI_PREPROCESS
            /// </summary>
            public static readonly LogTypeEnum ADMIN_STOP_ACTION_GENERATE_ORI_PREPROCESS = new LogTypeEnum("ADMIN_STOP_ACTION_GENERATE_ORI_PREPROCESS");

            /// <summary>
            /// Enum SYSTEM_BEAUTY_PREPROCESS_SUCCESS for value: SYSTEM_BEAUTY_PREPROCESS_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_BEAUTY_PREPROCESS_SUCCESS = new LogTypeEnum("SYSTEM_BEAUTY_PREPROCESS_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_COMPILE_FAILED for value: SYSTEM_COMPILE_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_COMPILE_FAILED = new LogTypeEnum("SYSTEM_COMPILE_FAILED");

            /// <summary>
            /// Enum SYSTEM_COMPILE_SUCCESS for value: SYSTEM_COMPILE_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_COMPILE_SUCCESS = new LogTypeEnum("SYSTEM_COMPILE_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_MARKABLE_VIDEO_FAILED for value: SYSTEM_MARKABLE_VIDEO_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_MARKABLE_VIDEO_FAILED = new LogTypeEnum("SYSTEM_MARKABLE_VIDEO_FAILED");

            /// <summary>
            /// Enum ADMIN_UPDATE_COMPILE for value: ADMIN_UPDATE_COMPILE
            /// </summary>
            public static readonly LogTypeEnum ADMIN_UPDATE_COMPILE = new LogTypeEnum("ADMIN_UPDATE_COMPILE");

            /// <summary>
            /// Enum ADMIN_UPDATE_INFERENCE_DATA_PROCESS_VIDEO for value: ADMIN_UPDATE_INFERENCE_DATA_PROCESS_VIDEO
            /// </summary>
            public static readonly LogTypeEnum ADMIN_UPDATE_INFERENCE_DATA_PROCESS_VIDEO = new LogTypeEnum("ADMIN_UPDATE_INFERENCE_DATA_PROCESS_VIDEO");

            /// <summary>
            /// Enum SYSTEM_EXECUTE_COMPILE for value: SYSTEM_EXECUTE_COMPILE
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_EXECUTE_COMPILE = new LogTypeEnum("SYSTEM_EXECUTE_COMPILE");

            /// <summary>
            /// Enum SYSTEM_EXECUTE_BEAUTY for value: SYSTEM_EXECUTE_BEAUTY
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_EXECUTE_BEAUTY = new LogTypeEnum("SYSTEM_EXECUTE_BEAUTY");

            /// <summary>
            /// Enum SYSTEM_MASK_VIDEO_AND_ACTION_TIME_SUCCESS for value: SYSTEM_MASK_VIDEO_AND_ACTION_TIME_SUCCESS
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_MASK_VIDEO_AND_ACTION_TIME_SUCCESS = new LogTypeEnum("SYSTEM_MASK_VIDEO_AND_ACTION_TIME_SUCCESS");

            /// <summary>
            /// Enum SYSTEM_MASK_VIDEO_AND_ACTION_TIME_FAILED for value: SYSTEM_MASK_VIDEO_AND_ACTION_TIME_FAILED
            /// </summary>
            public static readonly LogTypeEnum SYSTEM_MASK_VIDEO_AND_ACTION_TIME_FAILED = new LogTypeEnum("SYSTEM_MASK_VIDEO_AND_ACTION_TIME_FAILED");

            /// <summary>
            /// Enum USER_UPDATE_VIDEO for value: USER_UPDATE_VIDEO
            /// </summary>
            public static readonly LogTypeEnum USER_UPDATE_VIDEO = new LogTypeEnum("USER_UPDATE_VIDEO");

            /// <summary>
            /// Enum ADMIN_UPDATE_GENERAL_CONFIG for value: ADMIN_UPDATE_GENERAL_CONFIG
            /// </summary>
            public static readonly LogTypeEnum ADMIN_UPDATE_GENERAL_CONFIG = new LogTypeEnum("ADMIN_UPDATE_GENERAL_CONFIG");

            /// <summary>
            /// Enum ADMIN_MASK_ACTION_TIME for value: ADMIN_MASK_ACTION_TIME
            /// </summary>
            public static readonly LogTypeEnum ADMIN_MASK_ACTION_TIME = new LogTypeEnum("ADMIN_MASK_ACTION_TIME");

            /// <summary>
            /// Enum STOP_COMPILE for value: STOP_COMPILE
            /// </summary>
            public static readonly LogTypeEnum STOP_COMPILE = new LogTypeEnum("STOP_COMPILE");

            private static readonly Dictionary<string, LogTypeEnum> StaticFields =
            new Dictionary<string, LogTypeEnum>()
            {
                { "USER_CREATE_JOD", USER_CREATE_JOD },
                { "USER_VERIFYING_SUBMITTED", USER_VERIFYING_SUBMITTED },
                { "SYSTEM_VERIFY_FAILED", SYSTEM_VERIFY_FAILED },
                { "ADMIN_UPDATE_BEAUTY_LEVEL", ADMIN_UPDATE_BEAUTY_LEVEL },
                { "SYSTEM_VERIFY_SUCCESS", SYSTEM_VERIFY_SUCCESS },
                { "ADMIN_VERIFY_SUCCESS", ADMIN_VERIFY_SUCCESS },
                { "ADMIN_VERIFY_FAILED", ADMIN_VERIFY_FAILED },
                { "SYSTEM_TRAIN_DATA_PREPROCESSING", SYSTEM_TRAIN_DATA_PREPROCESSING },
                { "SYSTEM_TRAIN_DATA_PREPROCESS_FAILED", SYSTEM_TRAIN_DATA_PREPROCESS_FAILED },
                { "SYSTEM_TRAIN_DATA_PREPROCESS_SUCCESS", SYSTEM_TRAIN_DATA_PREPROCESS_SUCCESS },
                { "SYSTEM_ACTION_GENERATE_DATA_PREPROCESSING", SYSTEM_ACTION_GENERATE_DATA_PREPROCESSING },
                { "SYSTEM_ACTION_GENERATE_DATA_SUCCESS", SYSTEM_ACTION_GENERATE_DATA_SUCCESS },
                { "SYSTEM_ACTION_GENERATE_ORI_SUCCESS", SYSTEM_ACTION_GENERATE_ORI_SUCCESS },
                { "SYSTEM_ACTION_GENERATE_DATA_FAILED", SYSTEM_ACTION_GENERATE_DATA_FAILED },
                { "SYSTEM_ACTION_GENERATE_ORI_FAILED", SYSTEM_ACTION_GENERATE_ORI_FAILED },
                { "SYSTEM_ACTION_GENERATE_ORI_PREPROCESSING", SYSTEM_ACTION_GENERATE_ORI_PREPROCESSING },
                { "SYSTEM_TRAINING", SYSTEM_TRAINING },
                { "ADMIN_STOP_TRAINING_DATA_PREPROCESS", ADMIN_STOP_TRAINING_DATA_PREPROCESS },
                { "ADMIN_STOP_BEAUTY_PREPROCESS", ADMIN_STOP_BEAUTY_PREPROCESS },
                { "ADMIN_STOP_INFERENCE_DATA_PREPROCESS", ADMIN_STOP_INFERENCE_DATA_PREPROCESS },
                { "ADMIN_STOP_TRAIN", ADMIN_STOP_TRAIN },
                { "SYSTEM_TRAIN_FAILED", SYSTEM_TRAIN_FAILED },
                { "SYSTEM_TRAIN_SUCCESS", SYSTEM_TRAIN_SUCCESS },
                { "SYSTEM_INFERENCE_DATA_PREPROCESSING", SYSTEM_INFERENCE_DATA_PREPROCESSING },
                { "SYSTEM_INFERENCE_DATA_PREPROCESS_FAILED", SYSTEM_INFERENCE_DATA_PREPROCESS_FAILED },
                { "SYSTEM_INFERENCE_DATA_PREPROCESS_SUCCESS", SYSTEM_INFERENCE_DATA_PREPROCESS_SUCCESS },
                { "SYSTEM_JOB_SUCCESS", SYSTEM_JOB_SUCCESS },
                { "ADMIN_MASK_UPLOADED", ADMIN_MASK_UPLOADED },
                { "ADMIN_UPDATE_VIDEO", ADMIN_UPDATE_VIDEO },
                { "ADMIN_UPDATE_ACTION_VIDEO", ADMIN_UPDATE_ACTION_VIDEO },
                { "ADMIN_RESET", ADMIN_RESET },
                { "ADMIN_ACCEPT", ADMIN_ACCEPT },
                { "USER_REPAIR", USER_REPAIR },
                { "SYSTEM_UPDATE_COVER", SYSTEM_UPDATE_COVER },
                { "ADMIN_SET_SILENCE_REPEAT_NUM", ADMIN_SET_SILENCE_REPEAT_NUM },
                { "SYSTEM_MARKABLE_VIDEO", SYSTEM_MARKABLE_VIDEO },
                { "SYSTEM_MASK_VERIFY_VIDEO", SYSTEM_MASK_VERIFY_VIDEO },
                { "SYSTEM_MASK_VERIFY_VIDEO_SUCCESS", SYSTEM_MASK_VERIFY_VIDEO_SUCCESS },
                { "SYSTEM_MASK_VERIFY_VIDEO_FAILED", SYSTEM_MASK_VERIFY_VIDEO_FAILED },
                { "SYSTEM_MARKABLE_VIDEO_SUCCESS", SYSTEM_MARKABLE_VIDEO_SUCCESS },
                { "SYSTEM_BEAUTY_PREPROCESSING", SYSTEM_BEAUTY_PREPROCESSING },
                { "SYSTEM_BEAUTY_PREPROCESS_FAILED", SYSTEM_BEAUTY_PREPROCESS_FAILED },
                { "ADMIN_CONFIRM_ACTION", ADMIN_CONFIRM_ACTION },
                { "ADMIN_STOP_ACTION_GENERATE_DATA_PREPROCESS", ADMIN_STOP_ACTION_GENERATE_DATA_PREPROCESS },
                { "ADMIN_STOP_ACTION_GENERATE_ORI_PREPROCESS", ADMIN_STOP_ACTION_GENERATE_ORI_PREPROCESS },
                { "SYSTEM_BEAUTY_PREPROCESS_SUCCESS", SYSTEM_BEAUTY_PREPROCESS_SUCCESS },
                { "SYSTEM_COMPILE_FAILED", SYSTEM_COMPILE_FAILED },
                { "SYSTEM_COMPILE_SUCCESS", SYSTEM_COMPILE_SUCCESS },
                { "SYSTEM_MARKABLE_VIDEO_FAILED", SYSTEM_MARKABLE_VIDEO_FAILED },
                { "ADMIN_UPDATE_COMPILE", ADMIN_UPDATE_COMPILE },
                { "ADMIN_UPDATE_INFERENCE_DATA_PROCESS_VIDEO", ADMIN_UPDATE_INFERENCE_DATA_PROCESS_VIDEO },
                { "SYSTEM_EXECUTE_COMPILE", SYSTEM_EXECUTE_COMPILE },
                { "SYSTEM_EXECUTE_BEAUTY", SYSTEM_EXECUTE_BEAUTY },
                { "SYSTEM_MASK_VIDEO_AND_ACTION_TIME_SUCCESS", SYSTEM_MASK_VIDEO_AND_ACTION_TIME_SUCCESS },
                { "SYSTEM_MASK_VIDEO_AND_ACTION_TIME_FAILED", SYSTEM_MASK_VIDEO_AND_ACTION_TIME_FAILED },
                { "USER_UPDATE_VIDEO", USER_UPDATE_VIDEO },
                { "ADMIN_UPDATE_GENERAL_CONFIG", ADMIN_UPDATE_GENERAL_CONFIG },
                { "ADMIN_MASK_ACTION_TIME", ADMIN_MASK_ACTION_TIME },
                { "STOP_COMPILE", STOP_COMPILE },
            };

            private string _value;

            public LogTypeEnum()
            {

            }

            public LogTypeEnum(string value)
            {
                _value = value;
            }

            public static LogTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LogTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogTypeEnum a, LogTypeEnum b)
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

            public static bool operator !=(LogTypeEnum a, LogTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 操作人员。 * USER：用户 * ADMIN：管理员 * SYSTEM：系统
        /// </summary>
        /// <value>操作人员。 * USER：用户 * ADMIN：管理员 * SYSTEM：系统</value>
        [JsonConverter(typeof(EnumClassConverter<OperateUserEnum>))]
        public class OperateUserEnum
        {
            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            public static readonly OperateUserEnum USER = new OperateUserEnum("USER");

            /// <summary>
            /// Enum ADMIN for value: ADMIN
            /// </summary>
            public static readonly OperateUserEnum ADMIN = new OperateUserEnum("ADMIN");

            /// <summary>
            /// Enum SYSTEM for value: SYSTEM
            /// </summary>
            public static readonly OperateUserEnum SYSTEM = new OperateUserEnum("SYSTEM");

            private static readonly Dictionary<string, OperateUserEnum> StaticFields =
            new Dictionary<string, OperateUserEnum>()
            {
                { "USER", USER },
                { "ADMIN", ADMIN },
                { "SYSTEM", SYSTEM },
            };

            private string _value;

            public OperateUserEnum()
            {

            }

            public OperateUserEnum(string value)
            {
                _value = value;
            }

            public static OperateUserEnum FromValue(string value)
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

                if (this.Equals(obj as OperateUserEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperateUserEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperateUserEnum a, OperateUserEnum b)
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

            public static bool operator !=(OperateUserEnum a, OperateUserEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 操作时间,格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”
        /// </summary>
        [JsonProperty("operate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateTime { get; set; }

        /// <summary>
        /// 命令执行结果。 * USER_CREATE_JOD：用户开始分身数字人定制 * USER_VERIFYING_SUBMITTED：用户提交审核 * SYSTEM_VERIFY_FAILED：自动审核失败 * ADMIN_UPDATE_BEAUTY_LEVEL：管理员更新美白等级 * SYSTEM_VERIFY_SUCCESS：自动审核成功 * ADMIN_VERIFY_SUCCESS：人工审核通过 * ADMIN_VERIFY_FAILED：人工审核不通过 * SYSTEM_TRAIN_DATA_PREPROCESSING：训练数据预处理中 * SYSTEM_TRAIN_DATA_PREPROCESS_FAILED：训练数据预处理失败 * SYSTEM_TRAIN_DATA_PREPROCESS_SUCCESS：训练数据预处理成功 * SYSTEM_ACTION_GENERATE_DATA_PREPROCESSING：动作编排原子动作生成中 * SYSTEM_ACTION_GENERATE_DATA_SUCCESS：动作编排原子动作生成成功 * SYSTEM_ACTION_GENERATE_ORI_SUCCESS：动作编排资产数据生成成功 * SYSTEM_ACTION_GENERATE_DATA_FAILED：动作编排原子动作生成失败 * SYSTEM_ACTION_GENERATE_ORI_FAILED：动作编排资产数据生成失败 * SYSTEM_ACTION_GENERATE_ORI_PREPROCESSING：动作编排资产数据生成中 * SYSTEM_TRAINING：开始训练 * ADMIN_STOP_TRAINING_DATA_PREPROCESS：人工中止训练 * ADMIN_STOP_BEAUTY_PREPROCESS：人工中止美白 * ADMIN_STOP_INFERENCE_DATA_PREPROCESS：人工中止推理预处理 * ADMIN_STOP_TRAIN：人工终止训练 * SYSTEM_TRAIN_FAILED：训练失败 * SYSTEM_TRAIN_SUCCESS：训练成功 * SYSTEM_INFERENCE_DATA_PREPROCESSING：推理数据预处理中 * SYSTEM_INFERENCE_DATA_PREPROCESS_FAILED：推理数据预处理失败 * SYSTEM_INFERENCE_DATA_PREPROCESS_SUCCESS：推理数据预处理成功 * SYSTEM_JOB_SUCCESS：任务处理完成 * ADMIN_MASK_UPLOADED：遮罩文件上传完成（已废弃） * ADMIN_UPDATE_VIDEO：管理员更换视频 * ADMIN_UPDATE_ACTION_VIDEO：管理员更换动作编排视频 * ADMIN_RESET：管理员一键重置 * ADMIN_ACCEPT：管理员通过 * USER_REPAIR：用户修复 * SYSTEM_UPDATE_COVER：更换封面 * ADMIN_SET_SILENCE_REPEAT_NUM：管理员设置静默轮数 * SYSTEM_MARKABLE_VIDEO：标记视频生成任务 * SYSTEM_MASK_VERIFY_VIDEO：校验视频生成任务 * SYSTEM_MASK_VERIFY_VIDEO_SUCCESS：校验视频生成成功 * SYSTEM_MASK_VERIFY_VIDEO_FAILED：校验视频生成失败 * SYSTEM_MARKABLE_VIDEO_SUCCESS：标记视频生成成功 * SYSTEM_BEAUTY_PREPROCESSING：美白处理中 * SYSTEM_BEAUTY_PREPROCESS_FAILED：美白处理失败 * ADMIN_CONFIRM_ACTION：管理员确认动作 * ADMIN_STOP_ACTION_GENERATE_DATA_PREPROCESS：人工中止原子动作生成 * ADMIN_STOP_ACTION_GENERATE_ORI_PREPROCESS：人工中止动作编排 * SYSTEM_BEAUTY_PREPROCESS_SUCCESS：美白视频训练预处理成功 * SYSTEM_COMPILE_FAILED：转编译失败 * SYSTEM_COMPILE_SUCCESS：转编译成功 * SYSTEM_MARKABLE_VIDEO_FAILED：标记视频生成失败 * ADMIN_UPDATE_COMPILE：管理员更新转编译配置 * ADMIN_UPDATE_INFERENCE_DATA_PROCESS_VIDEO：管理员更新推理预处理时间段信息 * SYSTEM_EXECUTE_COMPILE：执行转编译 * SYSTEM_EXECUTE_BEAUTY：执行美白处理 * SYSTEM_MASK_VIDEO_AND_ACTION_TIME_SUCCESS：自动标记成功 * SYSTEM_MASK_VIDEO_AND_ACTION_TIME_FAILED：自动标记失败 * USER_UPDATE_VIDEO：用户更换视频 * ADMIN_UPDATE_GENERAL_CONFIG：管理员更新通用配置 * ADMIN_MASK_ACTION_TIME：管理员标记 * STOP_COMPILE：人工中止转编译
        /// </summary>
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public LogTypeEnum LogType { get; set; }
        /// <summary>
        /// 日志描述。用于记录人工或自动审核不通过时的审核意见。
        /// </summary>
        [JsonProperty("log_description", NullValueHandling = NullValueHandling.Ignore)]
        public string LogDescription { get; set; }

        /// <summary>
        /// 操作人员。 * USER：用户 * ADMIN：管理员 * SYSTEM：系统
        /// </summary>
        [JsonProperty("operate_user", NullValueHandling = NullValueHandling.Ignore)]
        public OperateUserEnum OperateUser { get; set; }
        /// <summary>
        /// 系统自动驳回时的错误码： * 44005901：视频分辨率不符合要求，目前只接受 1080p(1920x1080, 1080x1920) 或 4K(3840x2160, 2160x3840) 这四种分辨率
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationLogInfo {\n");
            sb.Append("  operateTime: ").Append(OperateTime).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  logDescription: ").Append(LogDescription).Append("\n");
            sb.Append("  operateUser: ").Append(OperateUser).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationLogInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationLogInfo input)
        {
            if (input == null) return false;
            if (this.OperateTime != input.OperateTime || (this.OperateTime != null && !this.OperateTime.Equals(input.OperateTime))) return false;
            if (this.LogType != input.LogType) return false;
            if (this.LogDescription != input.LogDescription || (this.LogDescription != null && !this.LogDescription.Equals(input.LogDescription))) return false;
            if (this.OperateUser != input.OperateUser) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;

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
                if (this.OperateTime != null) hashCode = hashCode * 59 + this.OperateTime.GetHashCode();
                hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.LogDescription != null) hashCode = hashCode * 59 + this.LogDescription.GetHashCode();
                hashCode = hashCode * 59 + this.OperateUser.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
