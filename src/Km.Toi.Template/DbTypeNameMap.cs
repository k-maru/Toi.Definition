﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Km.Toi.Template
{
    /// <summary>
    /// CLR型と <see cref="DbTypeName"/> で定義されたデータベース型名とのマッピングを定義します。
    /// </summary>
    public sealed class DbTypeNameMap: Dictionary<Type, string>
    {
        
        private DbTypeNameMap()
        {

        }
        /// <summary>
        /// 既定のマッピング情報を生成します。
        /// </summary>
        /// <returns>既定のマッピング情報</returns>
        public static DbTypeNameMap Default() => new DbTypeNameMap
        {
            [typeof(byte)] = DbTypeName.Byte,
            [typeof(sbyte)] = DbTypeName.SByte,
            [typeof(short)] = DbTypeName.Int16,
            [typeof(ushort)] = DbTypeName.UInt16,
            [typeof(int)] = DbTypeName.Int32,
            [typeof(uint)] = DbTypeName.UInt32,
            [typeof(long)] = DbTypeName.Int64,
            [typeof(ulong)] = DbTypeName.UInt64,
            [typeof(float)] = DbTypeName.Single,
            [typeof(double)] = DbTypeName.Double,
            [typeof(decimal)] = DbTypeName.Decimal,
            [typeof(bool)] = DbTypeName.Boolean,
            [typeof(string)] = DbTypeName.String,
            [typeof(char)] = DbTypeName.StringFixedLength,
            [typeof(Guid)] = DbTypeName.Guid,
            [typeof(DateTime)] = DbTypeName.DateTime,
            [typeof(DateTimeOffset)] = DbTypeName.DateTimeOffset,
            [typeof(TimeSpan)] = DbTypeName.Time,
            [typeof(byte[])] = DbTypeName.Binary,
            [typeof(byte?)] = DbTypeName.Byte,
            [typeof(sbyte?)] = DbTypeName.SByte,
            [typeof(short?)] = DbTypeName.Int16,
            [typeof(ushort?)] = DbTypeName.UInt16,
            [typeof(int?)] = DbTypeName.Int32,
            [typeof(uint?)] = DbTypeName.UInt32,
            [typeof(long?)] = DbTypeName.Int64,
            [typeof(ulong?)] = DbTypeName.UInt64,
            [typeof(float?)] = DbTypeName.Single,
            [typeof(double?)] = DbTypeName.Double,
            [typeof(decimal?)] = DbTypeName.Decimal,
            [typeof(bool?)] = DbTypeName.Boolean,
            [typeof(char?)] = DbTypeName.StringFixedLength,
            [typeof(Guid?)] = DbTypeName.Guid,
            [typeof(DateTime?)] = DbTypeName.DateTime,
            [typeof(DateTimeOffset?)] = DbTypeName.DateTimeOffset,
            [typeof(TimeSpan?)] = DbTypeName.Time,
            [typeof(object)] = DbTypeName.Object,
        };

    }
}
