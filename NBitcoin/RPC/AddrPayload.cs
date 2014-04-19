﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBitcoin.RPC
{
	[Payload("addr")]
	public class AddrPayload : IBitcoinSerializable
	{
		NetworkAddress[] addr_list = new NetworkAddress[0];
		public NetworkAddress[] Addresses
		{
			get
			{
				return addr_list;
			}
		}

		#region IBitcoinSerializable Members

		public void ReadWrite(BitcoinStream stream)
		{
			stream.ReadWrite(ref addr_list);
		}

		#endregion
	}
}