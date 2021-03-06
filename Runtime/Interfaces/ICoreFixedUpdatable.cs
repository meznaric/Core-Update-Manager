﻿//* ---------------------------------------------------------------
//* "THE BEERWARE LICENSE" (Revision 42):
//* Nikolai "Kolyasisan" Ponomarev @ PCHK Studios wrote this code.
//* As long as you retain this notice, you can do whatever you
//* want with this stuff. If we meet someday, and you think this
//* stuff is worth it, you can buy me a beer in return.
//* ---------------------------------------------------------------

public interface ICoreFixedUpdatable : IUpdatableBase
{
    void CoreFixedUpdate();
    UpdateLoopSettings UpdateLoopSettings_CoreFixedUpdate { get; set; }
}
