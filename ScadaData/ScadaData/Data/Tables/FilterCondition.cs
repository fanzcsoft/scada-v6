﻿/*
 * Copyright 2020 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaData
 * Summary  : Represents a filter condition
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2020
 * Modified : 2020
 */

using System.ComponentModel;

namespace Scada.Data.Tables
{
    /// <summary>
    /// Represents a filter condition.
    /// <para>Представляет условие фильтра.</para>
    /// </summary>
    public class FilterCondition
    {
        /// <summary>
        /// Gets or sets the column name to filter.
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets the column property.
        /// </summary>
        public PropertyDescriptor ColumnProperty { get; set; }

        /// <summary>
        /// Gets or sets the column data type.
        /// </summary>
        public ColumnDataType DataType { get; set; }

        /// <summary>
        /// Gets or sets the filter operator.
        /// </summary>
        public FilterOperator Operator { get; set; }

        /// <summary>
        /// Gets or sets the filter argument.
        /// </summary>
        public object Argument { get; set; }


        /// <summary>
        /// Checks if the specified item satisfies the condition.
        /// </summary>
        public bool IsSatisfied(object item)
        {
            return false;
        }
    }
}
