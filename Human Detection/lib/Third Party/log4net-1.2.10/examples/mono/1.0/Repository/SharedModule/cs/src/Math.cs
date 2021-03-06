#region Copyright & License
//
// Copyright 2001-2005 The Apache Software Foundation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

namespace SharedModule
{
	/// <summary>
	/// Summary description for Math.
	/// </summary>
	public class Math
	{
		// Create a logger for use in this class
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public Math()
		{
			if (log.IsDebugEnabled) log.Debug("Constructor");
		}

		public int Subtract(int left, int right)
		{
			int result = left - right;
			if (log.IsInfoEnabled) log.Info(""+left+" - "+right+" = "+result);
			return result;
		}
	}
}
