// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Windows.Forms;
using TerraFX.Samples.DirectX.D3D12;
namespace TerraFX.Samples.WinForms
{
    public class DX12Panel : Panel
    {
        private readonly DX12Viewport _dxVp;
        public DX12Viewport DxVp => _dxVp;

        public DX12Panel(int width, int height) : base()
        {
            _dxVp = InitializeViewport(width, height);
            Resize += OnResize;
        }

        private DX12Viewport InitializeViewport(int width, int height)
        {
            var dxVp = new DX12Viewport((uint)width, (uint)height, Handle);
            dxVp.OnInit();
            return dxVp;
        }

        private void OnResize(object? sender, EventArgs eventArgs)
        {
            _dxVp.OnResize((uint)Width, (uint)Height);
            // _dxVp.OnInit(); // IB: crashes on resoure reinitialization, needs instead a _dxVp.OnResize that updates existing resources
            _dxVp.OnRender();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _dxVp.OnRender();
        }
    }
}
