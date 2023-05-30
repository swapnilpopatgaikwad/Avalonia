//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     GenAPI Version: 7.0.8.6004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Avalonia
{
    public static partial class Win32ApplicationExtensions
    {
        public static Avalonia.AppBuilder UseWin32(this Avalonia.AppBuilder builder) { throw null; }
    }
    public partial class Win32PlatformOptions
    {
        public Win32PlatformOptions() { }
        public bool? AllowEglInitialization { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public float? CompositionBackdropCornerRadius { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Platform.IPlatformGraphics? CustomPlatformGraphics { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public bool OverlayPopups { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public bool ShouldRenderOnUIThread { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public bool UseLowLatencyDxgiSwapChain { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public bool UseWgl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public bool UseWindowsUIComposition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.Collections.Generic.IList<Avalonia.OpenGL.GlVersion> WglProfiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
    }
}
namespace Avalonia.Win32
{
    public partial class AngleOptions
    {
        public AngleOptions() { }
        public System.Collections.Generic.IList<Avalonia.Win32.AngleOptions.PlatformApi>? AllowedPlatformApis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.Collections.Generic.IList<Avalonia.OpenGL.GlVersion> GlProfiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public enum PlatformApi
        {
            DirectX9 = 0,
            DirectX11 = 1,
        }
    }
}
namespace Avalonia.Win32.DirectX
{
    public partial interface IDirect3D11TexturePlatformSurface
    {
        Avalonia.Win32.DirectX.IDirect3D11TextureRenderTarget CreateRenderTarget(Avalonia.Platform.IPlatformGraphicsContext graphicsContext, System.IntPtr d3dDevice);
    }
    public partial interface IDirect3D11TextureRenderTarget : System.IDisposable
    {
        bool IsCorrupted { get; }
        Avalonia.Win32.DirectX.IDirect3D11TextureRenderTargetRenderSession BeginDraw();
    }
    public partial interface IDirect3D11TextureRenderTargetRenderSession : System.IDisposable
    {
        System.IntPtr D3D11Texture2D { get; }
        Avalonia.PixelPoint Offset { get; }
        double Scaling { get; }
        Avalonia.PixelSize Size { get; }
    }
}
namespace Avalonia.Win32.Input
{
    public static partial class KeyInterop
    {
        public static Avalonia.Input.Key KeyFromVirtualKey(int virtualKey, int keyData) { throw null; }
        public static int VirtualKeyFromKey(Avalonia.Input.Key key) { throw null; }
    }
}
namespace Avalonia.Win32.Interop.Automation
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("70d46e77-e3a8-449d-913c-e30eb2afecdb")]
    public enum DockPosition
    {
        Top = 0,
        Left = 1,
        Bottom = 2,
        Right = 3,
        Fill = 4,
        None = 5,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("159bc72c-4ad3-485e-9637-d7052edf0146")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDockProvider
    {
        Avalonia.Win32.Interop.Automation.DockPosition DockPosition { get; }
        void SetDockPosition(Avalonia.Win32.Interop.Automation.DockPosition dockPosition);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("d847d3a5-cab0-4a98-8c32-ecb45c59ad24")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IExpandCollapseProvider
    {
        Avalonia.Automation.ExpandCollapseState ExpandCollapseState { get; }
        void Collapse();
        void Expand();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("d02541f1-fb81-4d64-ae32-f520f8a6dbd1")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGridItemProvider
    {
        int Column { get; }
        int ColumnSpan { get; }
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple ContainingGrid { get; }
        int Row { get; }
        int RowSpan { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("b17d6187-0907-464b-a168-0ef17a1572b1")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGridProvider
    {
        int ColumnCount { get; }
        int RowCount { get; }
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple? GetItem(int row, int column);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("54fcb24b-e18e-47a2-b4d3-eccbe77599a2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IInvokeProvider
    {
        void Invoke();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("6278cab1-b556-4a1a-b4e0-418acc523201")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMultipleViewProvider
    {
        int CurrentView { get; }
        int[] GetSupportedViews();
        string GetViewName(int viewId);
        void SetCurrentView(int viewId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("36dc7aef-33e6-4691-afe1-2be7274b3d33")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IRangeValueProvider
    {
        bool IsReadOnly { get; }
        double LargeChange { get; }
        double Maximum { get; }
        double Minimum { get; }
        double SmallChange { get; }
        double Value { get; }
        void SetValue(double value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("a407b27b-0f6d-4427-9292-473c7bf93258")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IRawElementProviderAdviseEvents : Avalonia.Win32.Interop.Automation.IRawElementProviderSimple
    {
        void AdviseEventAdded(int eventId, int[] properties);
        void AdviseEventRemoved(int eventId, int[] properties);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("f7063da8-8359-439c-9297-bbc5299a7d87")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IRawElementProviderFragment : Avalonia.Win32.Interop.Automation.IRawElementProviderSimple
    {
        Avalonia.Rect BoundingRectangle { get; }
        Avalonia.Win32.Interop.Automation.IRawElementProviderFragmentRoot? FragmentRoot { get; }
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple[]? GetEmbeddedFragmentRoots();
        int[]? GetRuntimeId();
        Avalonia.Win32.Interop.Automation.IRawElementProviderFragment? Navigate(Avalonia.Win32.Interop.Automation.NavigateDirection direction);
        void SetFocus();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("620ce2a5-ab8f-40a9-86cb-de3c75599b58")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IRawElementProviderFragmentRoot : Avalonia.Win32.Interop.Automation.IRawElementProviderFragment, Avalonia.Win32.Interop.Automation.IRawElementProviderSimple
    {
        Avalonia.Win32.Interop.Automation.IRawElementProviderFragment? ElementProviderFromPoint(double x, double y);
        Avalonia.Win32.Interop.Automation.IRawElementProviderFragment? GetFocus();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("d6dd68d1-86fd-4332-8666-9abedea2d24c")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IRawElementProviderSimple
    {
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple? HostRawElementProvider { get; }
        Avalonia.Win32.Interop.Automation.ProviderOptions ProviderOptions { get; }
        object? GetPatternProvider(int patternId);
        object? GetPropertyValue(int propertyId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("a0a839a9-8da1-4a82-806a-8e0d44e79f56")]
    public partial interface IRawElementProviderSimple2
    {
        void ShowContextMenu();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("2360c714-4bf1-4b26-ba65-9b21316127eb")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IScrollItemProvider
    {
        void ScrollIntoView();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("b38b8077-1fc3-42a5-8cae-d40c2215055a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IScrollProvider
    {
        bool HorizontallyScrollable { get; }
        double HorizontalScrollPercent { get; }
        double HorizontalViewSize { get; }
        bool VerticallyScrollable { get; }
        double VerticalScrollPercent { get; }
        double VerticalViewSize { get; }
        void Scroll(Avalonia.Automation.Provider.ScrollAmount horizontalAmount, Avalonia.Automation.Provider.ScrollAmount verticalAmount);
        void SetScrollPercent(double horizontalPercent, double verticalPercent);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("2acad808-b2d4-452d-a407-91ff1ad167b2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISelectionItemProvider
    {
        bool IsSelected { get; }
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple? SelectionContainer { get; }
        void AddToSelection();
        void RemoveFromSelection();
        void Select();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("fb8b03af-3bdf-48d4-bd36-1a65793be168")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISelectionProvider
    {
        bool CanSelectMultiple { get; }
        bool IsSelectionRequired { get; }
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple[] GetSelection();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("29db1a06-02ce-4cf7-9b42-565d4fab20ee")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISynchronizedInputProvider
    {
        void Cancel();
        void StartListening(Avalonia.Win32.Interop.Automation.SynchronizedInputType inputType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("b9734fa6-771f-4d78-9c90-2517999349cd")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ITableItemProvider : Avalonia.Win32.Interop.Automation.IGridItemProvider
    {
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple[] GetColumnHeaderItems();
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple[] GetRowHeaderItems();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("9c860395-97b3-490a-b52a-858cc22af166")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ITableProvider : Avalonia.Win32.Interop.Automation.IGridProvider
    {
        Avalonia.Win32.Interop.Automation.RowOrColumnMajor RowOrColumnMajor { get; }
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple[] GetColumnHeaders();
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple[] GetRowHeaders();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("3589c92c-63f3-4367-99bb-ada653b77cf2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ITextProvider
    {
        Avalonia.Win32.Interop.Automation.ITextRangeProvider DocumentRange { get; }
        Avalonia.Win32.Interop.Automation.SupportedTextSelection SupportedTextSelection { get; }
        Avalonia.Win32.Interop.Automation.ITextRangeProvider[] GetSelection();
        Avalonia.Win32.Interop.Automation.ITextRangeProvider[] GetVisibleRanges();
        Avalonia.Win32.Interop.Automation.ITextRangeProvider RangeFromChild(Avalonia.Win32.Interop.Automation.IRawElementProviderSimple childElement);
        Avalonia.Win32.Interop.Automation.ITextRangeProvider RangeFromPoint(Avalonia.Point screenLocation);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("5347ad7b-c355-46f8-aff5-909033582f63")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ITextRangeProvider
    {
        void AddToSelection();
        Avalonia.Win32.Interop.Automation.ITextRangeProvider Clone();
        bool Compare(Avalonia.Win32.Interop.Automation.ITextRangeProvider range);
        int CompareEndpoints(Avalonia.Win32.Interop.Automation.TextPatternRangeEndpoint endpoint, Avalonia.Win32.Interop.Automation.ITextRangeProvider targetRange, Avalonia.Win32.Interop.Automation.TextPatternRangeEndpoint targetEndpoint);
        void ExpandToEnclosingUnit(Avalonia.Win32.Interop.Automation.TextUnit unit);
        Avalonia.Win32.Interop.Automation.ITextRangeProvider FindAttribute(int attribute, object value, bool backward);
        Avalonia.Win32.Interop.Automation.ITextRangeProvider FindText(string text, bool backward, bool ignoreCase);
        object GetAttributeValue(int attribute);
        double[] GetBoundingRectangles();
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple[] GetChildren();
        Avalonia.Win32.Interop.Automation.IRawElementProviderSimple GetEnclosingElement();
        string GetText(int maxLength);
        int Move(Avalonia.Win32.Interop.Automation.TextUnit unit, int count);
        void MoveEndpointByRange(Avalonia.Win32.Interop.Automation.TextPatternRangeEndpoint endpoint, Avalonia.Win32.Interop.Automation.ITextRangeProvider targetRange, Avalonia.Win32.Interop.Automation.TextPatternRangeEndpoint targetEndpoint);
        int MoveEndpointByUnit(Avalonia.Win32.Interop.Automation.TextPatternRangeEndpoint endpoint, Avalonia.Win32.Interop.Automation.TextUnit unit, int count);
        void RemoveFromSelection();
        void ScrollIntoView(bool alignToTop);
        void Select();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("56d00bd0-c4f4-433c-a836-1a52a57e0892")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IToggleProvider
    {
        Avalonia.Automation.Provider.ToggleState ToggleState { get; }
        void Toggle();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("6829ddc4-4f91-4ffa-b86f-bd3e2987cb4c")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ITransformProvider
    {
        bool CanMove { get; }
        bool CanResize { get; }
        bool CanRotate { get; }
        void Move(double x, double y);
        void Resize(double width, double height);
        void Rotate(double degrees);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("c7935180-6fb3-4201-b174-7df73adbf64a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IValueProvider
    {
        bool IsReadOnly { get; }
        string? Value { get; }
        void SetValue(string? value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("987df77b-db06-4d77-8f8a-86a9c3bb90b9")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWindowProvider
    {
        Avalonia.Win32.Interop.Automation.WindowInteractionState InteractionState { get; }
        bool IsModal { get; }
        bool IsTopmost { get; }
        bool Maximizable { get; }
        bool Minimizable { get; }
        Avalonia.Win32.Interop.Automation.WindowVisualState VisualState { get; }
        void Close();
        void SetVisualState(Avalonia.Win32.Interop.Automation.WindowVisualState state);
        bool WaitForInputIdle(int milliseconds);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("670c3006-bf4c-428b-8534-e1848f645122")]
    public enum NavigateDirection
    {
        Parent = 0,
        NextSibling = 1,
        PreviousSibling = 2,
        FirstChild = 3,
        LastChild = 4,
    }
    [System.FlagsAttribute]
    public enum ProviderOptions
    {
        ClientSideProvider = 1,
        ServerSideProvider = 2,
        NonClientAreaProvider = 4,
        OverrideProvider = 8,
        ProviderOwnsSetFocus = 16,
        UseComThreading = 32,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("15fdf2e2-9847-41cd-95dd-510612a025ea")]
    public enum RowOrColumnMajor
    {
        RowMajor = 0,
        ColumnMajor = 1,
        Indeterminate = 2,
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("3d9e3d8f-bfb0-484f-84ab-93ff4280cbc4")]
    public enum SupportedTextSelection
    {
        None = 0,
        Single = 1,
        Multiple = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("fdc8f176-aed2-477a-8c89-5604c66f278d")]
    public enum SynchronizedInputType
    {
        KeyUp = 1,
        KeyDown = 2,
        MouseLeftButtonUp = 4,
        MouseLeftButtonDown = 8,
        MouseRightButtonUp = 16,
        MouseRightButtonDown = 32,
    }
    public enum TextPatternRangeEndpoint
    {
        Start = 0,
        End = 1,
    }
    public enum TextUnit
    {
        Character = 0,
        Format = 1,
        Word = 2,
        Line = 3,
        Paragraph = 4,
        Page = 5,
        Document = 6,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("65101cc7-7904-408e-87a7-8c6dbd83a18b")]
    public enum WindowInteractionState
    {
        Running = 0,
        Closing = 1,
        ReadyForUserInteraction = 2,
        BlockedByModalWindow = 3,
        NotResponding = 4,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("fdc8f176-aed2-477a-8c89-ea04cc5f278d")]
    public enum WindowVisualState
    {
        Normal = 0,
        Maximized = 1,
        Minimized = 2,
    }
}
