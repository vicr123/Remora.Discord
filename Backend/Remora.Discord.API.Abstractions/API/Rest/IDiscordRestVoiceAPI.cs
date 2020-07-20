//
//  IDiscordRestVoiceAPI.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Remora.Discord.API.Abstractions.Results;
using Remora.Discord.API.Abstractions.Voice;

namespace Remora.Discord.API.Abstractions
{
    /// <summary>
    /// Represents the Discord Voice API.
    /// </summary>
    [PublicAPI]
    public interface IDiscordRestVoiceAPI
    {
        /// <summary>
        /// Gets the available voice regions.
        /// </summary>
        /// <param name="ct">The cancellation token for this operation.</param>
        /// <returns>A retrieval result which may or may not have succeeded.</returns>
        Task<IRetrieveRestEntityResult<IVoiceRegion>> ListVoiceRegionsAsync(CancellationToken ct = default);
    }
}