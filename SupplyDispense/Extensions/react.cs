 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SupplyDispense.Extensions
{

public static class ButtonExtensions 
{
				
   public static IObservable<IEvent<EventArgs>> GetDoubleClick (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DoubleClick += h, 
               h=> el.DoubleClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseDoubleClick (this Button el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseDoubleClick += h, 
               h=> el.MouseDoubleClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetAutoSizeChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.AutoSizeChanged += h, 
               h=> el.AutoSizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetImeModeChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ImeModeChanged += h, 
               h=> el.ImeModeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackColorChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackColorChanged += h, 
               h=> el.BackColorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackgroundImageChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackgroundImageChanged += h, 
               h=> el.BackgroundImageChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackgroundImageLayoutChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackgroundImageLayoutChanged += h, 
               h=> el.BackgroundImageLayoutChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBindingContextChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BindingContextChanged += h, 
               h=> el.BindingContextChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetCausesValidationChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.CausesValidationChanged += h, 
               h=> el.CausesValidationChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetClientSizeChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ClientSizeChanged += h, 
               h=> el.ClientSizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetContextMenuChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ContextMenuChanged += h, 
               h=> el.ContextMenuChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetContextMenuStripChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ContextMenuStripChanged += h, 
               h=> el.ContextMenuStripChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetCursorChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.CursorChanged += h, 
               h=> el.CursorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDockChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DockChanged += h, 
               h=> el.DockChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetEnabledChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.EnabledChanged += h, 
               h=> el.EnabledChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetFontChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.FontChanged += h, 
               h=> el.FontChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetForeColorChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ForeColorChanged += h, 
               h=> el.ForeColorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLocationChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.LocationChanged += h, 
               h=> el.LocationChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMarginChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MarginChanged += h, 
               h=> el.MarginChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetRegionChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.RegionChanged += h, 
               h=> el.RegionChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetRightToLeftChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.RightToLeftChanged += h, 
               h=> el.RightToLeftChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetSizeChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.SizeChanged += h, 
               h=> el.SizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTabIndexChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TabIndexChanged += h, 
               h=> el.TabIndexChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTabStopChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TabStopChanged += h, 
               h=> el.TabStopChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTextChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TextChanged += h, 
               h=> el.TextChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetVisibleChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.VisibleChanged += h, 
               h=> el.VisibleChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetClick (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Click += h, 
               h=> el.Click -= h
            );          
   }
			
				
   public static IObservable<IEvent<ControlEventArgs>> GetControlAdded (this Button el)
   {                        
       return Observable.FromEvent<ControlEventHandler, ControlEventArgs>
           (   
		       h => new ControlEventHandler(h), 
               h => el.ControlAdded += h, 
               h=> el.ControlAdded -= h
            );          
   }
			
				
   public static IObservable<IEvent<ControlEventArgs>> GetControlRemoved (this Button el)
   {                        
       return Observable.FromEvent<ControlEventHandler, ControlEventArgs>
           (   
		       h => new ControlEventHandler(h), 
               h => el.ControlRemoved += h, 
               h=> el.ControlRemoved -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragDrop (this Button el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragDrop += h, 
               h=> el.DragDrop -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragEnter (this Button el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragEnter += h, 
               h=> el.DragEnter -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragOver (this Button el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragOver += h, 
               h=> el.DragOver -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDragLeave (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DragLeave += h, 
               h=> el.DragLeave -= h
            );          
   }
			
				
   public static IObservable<IEvent<GiveFeedbackEventArgs>> GetGiveFeedback (this Button el)
   {                        
       return Observable.FromEvent<GiveFeedbackEventHandler, GiveFeedbackEventArgs>
           (   
		       h => new GiveFeedbackEventHandler(h), 
               h => el.GiveFeedback += h, 
               h=> el.GiveFeedback -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetHandleCreated (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.HandleCreated += h, 
               h=> el.HandleCreated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetHandleDestroyed (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.HandleDestroyed += h, 
               h=> el.HandleDestroyed -= h
            );          
   }
			
				
   public static IObservable<IEvent<HelpEventArgs>> GetHelpRequested (this Button el)
   {                        
       return Observable.FromEvent<HelpEventHandler, HelpEventArgs>
           (   
		       h => new HelpEventHandler(h), 
               h => el.HelpRequested += h, 
               h=> el.HelpRequested -= h
            );          
   }
			
				
   public static IObservable<IEvent<InvalidateEventArgs>> GetInvalidated (this Button el)
   {                        
       return Observable.FromEvent<InvalidateEventHandler, InvalidateEventArgs>
           (   
		       h => new InvalidateEventHandler(h), 
               h => el.Invalidated += h, 
               h=> el.Invalidated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetPaddingChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.PaddingChanged += h, 
               h=> el.PaddingChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<PaintEventArgs>> GetPaint (this Button el)
   {                        
       return Observable.FromEvent<PaintEventHandler, PaintEventArgs>
           (   
		       h => new PaintEventHandler(h), 
               h => el.Paint += h, 
               h=> el.Paint -= h
            );          
   }
			
				
   public static IObservable<IEvent<QueryContinueDragEventArgs>> GetQueryContinueDrag (this Button el)
   {                        
       return Observable.FromEvent<QueryContinueDragEventHandler, QueryContinueDragEventArgs>
           (   
		       h => new QueryContinueDragEventHandler(h), 
               h => el.QueryContinueDrag += h, 
               h=> el.QueryContinueDrag -= h
            );          
   }
			
				
   public static IObservable<IEvent<QueryAccessibilityHelpEventArgs>> GetQueryAccessibilityHelp (this Button el)
   {                        
       return Observable.FromEvent<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>
           (   
		       h => new QueryAccessibilityHelpEventHandler(h), 
               h => el.QueryAccessibilityHelp += h, 
               h=> el.QueryAccessibilityHelp -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetEnter (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Enter += h, 
               h=> el.Enter -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetGotFocus (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.GotFocus += h, 
               h=> el.GotFocus -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyEventArgs>> GetKeyDown (this Button el)
   {                        
       return Observable.FromEvent<KeyEventHandler, KeyEventArgs>
           (   
		       h => new KeyEventHandler(h), 
               h => el.KeyDown += h, 
               h=> el.KeyDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyPressEventArgs>> GetKeyPress (this Button el)
   {                        
       return Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>
           (   
		       h => new KeyPressEventHandler(h), 
               h => el.KeyPress += h, 
               h=> el.KeyPress -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyEventArgs>> GetKeyUp (this Button el)
   {                        
       return Observable.FromEvent<KeyEventHandler, KeyEventArgs>
           (   
		       h => new KeyEventHandler(h), 
               h => el.KeyUp += h, 
               h=> el.KeyUp -= h
            );          
   }
			
				
   public static IObservable<IEvent<LayoutEventArgs>> GetLayout (this Button el)
   {                        
       return Observable.FromEvent<LayoutEventHandler, LayoutEventArgs>
           (   
		       h => new LayoutEventHandler(h), 
               h => el.Layout += h, 
               h=> el.Layout -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLeave (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Leave += h, 
               h=> el.Leave -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLostFocus (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.LostFocus += h, 
               h=> el.LostFocus -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseClick (this Button el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseClick += h, 
               h=> el.MouseClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseCaptureChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseCaptureChanged += h, 
               h=> el.MouseCaptureChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseDown (this Button el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseDown += h, 
               h=> el.MouseDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseEnter (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseEnter += h, 
               h=> el.MouseEnter -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseLeave (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseLeave += h, 
               h=> el.MouseLeave -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseHover (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseHover += h, 
               h=> el.MouseHover -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseMove (this Button el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseMove += h, 
               h=> el.MouseMove -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseUp (this Button el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseUp += h, 
               h=> el.MouseUp -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseWheel (this Button el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseWheel += h, 
               h=> el.MouseWheel -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMove (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Move += h, 
               h=> el.Move -= h
            );          
   }
			
				
   public static IObservable<IEvent<PreviewKeyDownEventArgs>> GetPreviewKeyDown (this Button el)
   {                        
       return Observable.FromEvent<PreviewKeyDownEventHandler, PreviewKeyDownEventArgs>
           (   
		       h => new PreviewKeyDownEventHandler(h), 
               h => el.PreviewKeyDown += h, 
               h=> el.PreviewKeyDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetResize (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Resize += h, 
               h=> el.Resize -= h
            );          
   }
			
				
   public static IObservable<IEvent<UICuesEventArgs>> GetChangeUICues (this Button el)
   {                        
       return Observable.FromEvent<UICuesEventHandler, UICuesEventArgs>
           (   
		       h => new UICuesEventHandler(h), 
               h => el.ChangeUICues += h, 
               h=> el.ChangeUICues -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetStyleChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.StyleChanged += h, 
               h=> el.StyleChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetSystemColorsChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.SystemColorsChanged += h, 
               h=> el.SystemColorsChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<CancelEventArgs>> GetValidating (this Button el)
   {                        
       return Observable.FromEvent<CancelEventHandler, CancelEventArgs>
           (   
		       h => new CancelEventHandler(h), 
               h => el.Validating += h, 
               h=> el.Validating -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetValidated (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Validated += h, 
               h=> el.Validated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetParentChanged (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ParentChanged += h, 
               h=> el.ParentChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDisposed (this Button el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Disposed += h, 
               h=> el.Disposed -= h
            );          
   }
			
	}

public static class TextBoxExtensions 
{
				
   public static IObservable<IEvent<EventArgs>> GetTextAlignChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TextAlignChanged += h, 
               h=> el.TextAlignChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetAcceptsTabChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.AcceptsTabChanged += h, 
               h=> el.AcceptsTabChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetAutoSizeChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.AutoSizeChanged += h, 
               h=> el.AutoSizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackgroundImageChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackgroundImageChanged += h, 
               h=> el.BackgroundImageChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackgroundImageLayoutChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackgroundImageLayoutChanged += h, 
               h=> el.BackgroundImageLayoutChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBorderStyleChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BorderStyleChanged += h, 
               h=> el.BorderStyleChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetClick (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Click += h, 
               h=> el.Click -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseClick (this TextBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseClick += h, 
               h=> el.MouseClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetHideSelectionChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.HideSelectionChanged += h, 
               h=> el.HideSelectionChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetModifiedChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ModifiedChanged += h, 
               h=> el.ModifiedChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMultilineChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MultilineChanged += h, 
               h=> el.MultilineChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetPaddingChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.PaddingChanged += h, 
               h=> el.PaddingChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetReadOnlyChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ReadOnlyChanged += h, 
               h=> el.ReadOnlyChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<PaintEventArgs>> GetPaint (this TextBox el)
   {                        
       return Observable.FromEvent<PaintEventHandler, PaintEventArgs>
           (   
		       h => new PaintEventHandler(h), 
               h => el.Paint += h, 
               h=> el.Paint -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackColorChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackColorChanged += h, 
               h=> el.BackColorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBindingContextChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BindingContextChanged += h, 
               h=> el.BindingContextChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetCausesValidationChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.CausesValidationChanged += h, 
               h=> el.CausesValidationChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetClientSizeChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ClientSizeChanged += h, 
               h=> el.ClientSizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetContextMenuChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ContextMenuChanged += h, 
               h=> el.ContextMenuChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetContextMenuStripChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ContextMenuStripChanged += h, 
               h=> el.ContextMenuStripChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetCursorChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.CursorChanged += h, 
               h=> el.CursorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDockChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DockChanged += h, 
               h=> el.DockChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetEnabledChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.EnabledChanged += h, 
               h=> el.EnabledChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetFontChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.FontChanged += h, 
               h=> el.FontChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetForeColorChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ForeColorChanged += h, 
               h=> el.ForeColorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLocationChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.LocationChanged += h, 
               h=> el.LocationChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMarginChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MarginChanged += h, 
               h=> el.MarginChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetRegionChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.RegionChanged += h, 
               h=> el.RegionChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetRightToLeftChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.RightToLeftChanged += h, 
               h=> el.RightToLeftChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetSizeChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.SizeChanged += h, 
               h=> el.SizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTabIndexChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TabIndexChanged += h, 
               h=> el.TabIndexChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTabStopChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TabStopChanged += h, 
               h=> el.TabStopChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTextChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TextChanged += h, 
               h=> el.TextChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetVisibleChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.VisibleChanged += h, 
               h=> el.VisibleChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<ControlEventArgs>> GetControlAdded (this TextBox el)
   {                        
       return Observable.FromEvent<ControlEventHandler, ControlEventArgs>
           (   
		       h => new ControlEventHandler(h), 
               h => el.ControlAdded += h, 
               h=> el.ControlAdded -= h
            );          
   }
			
				
   public static IObservable<IEvent<ControlEventArgs>> GetControlRemoved (this TextBox el)
   {                        
       return Observable.FromEvent<ControlEventHandler, ControlEventArgs>
           (   
		       h => new ControlEventHandler(h), 
               h => el.ControlRemoved += h, 
               h=> el.ControlRemoved -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragDrop (this TextBox el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragDrop += h, 
               h=> el.DragDrop -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragEnter (this TextBox el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragEnter += h, 
               h=> el.DragEnter -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragOver (this TextBox el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragOver += h, 
               h=> el.DragOver -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDragLeave (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DragLeave += h, 
               h=> el.DragLeave -= h
            );          
   }
			
				
   public static IObservable<IEvent<GiveFeedbackEventArgs>> GetGiveFeedback (this TextBox el)
   {                        
       return Observable.FromEvent<GiveFeedbackEventHandler, GiveFeedbackEventArgs>
           (   
		       h => new GiveFeedbackEventHandler(h), 
               h => el.GiveFeedback += h, 
               h=> el.GiveFeedback -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetHandleCreated (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.HandleCreated += h, 
               h=> el.HandleCreated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetHandleDestroyed (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.HandleDestroyed += h, 
               h=> el.HandleDestroyed -= h
            );          
   }
			
				
   public static IObservable<IEvent<HelpEventArgs>> GetHelpRequested (this TextBox el)
   {                        
       return Observable.FromEvent<HelpEventHandler, HelpEventArgs>
           (   
		       h => new HelpEventHandler(h), 
               h => el.HelpRequested += h, 
               h=> el.HelpRequested -= h
            );          
   }
			
				
   public static IObservable<IEvent<InvalidateEventArgs>> GetInvalidated (this TextBox el)
   {                        
       return Observable.FromEvent<InvalidateEventHandler, InvalidateEventArgs>
           (   
		       h => new InvalidateEventHandler(h), 
               h => el.Invalidated += h, 
               h=> el.Invalidated -= h
            );          
   }
			
				
   public static IObservable<IEvent<QueryContinueDragEventArgs>> GetQueryContinueDrag (this TextBox el)
   {                        
       return Observable.FromEvent<QueryContinueDragEventHandler, QueryContinueDragEventArgs>
           (   
		       h => new QueryContinueDragEventHandler(h), 
               h => el.QueryContinueDrag += h, 
               h=> el.QueryContinueDrag -= h
            );          
   }
			
				
   public static IObservable<IEvent<QueryAccessibilityHelpEventArgs>> GetQueryAccessibilityHelp (this TextBox el)
   {                        
       return Observable.FromEvent<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>
           (   
		       h => new QueryAccessibilityHelpEventHandler(h), 
               h => el.QueryAccessibilityHelp += h, 
               h=> el.QueryAccessibilityHelp -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDoubleClick (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DoubleClick += h, 
               h=> el.DoubleClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetEnter (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Enter += h, 
               h=> el.Enter -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetGotFocus (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.GotFocus += h, 
               h=> el.GotFocus -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyEventArgs>> GetKeyDown (this TextBox el)
   {                        
       return Observable.FromEvent<KeyEventHandler, KeyEventArgs>
           (   
		       h => new KeyEventHandler(h), 
               h => el.KeyDown += h, 
               h=> el.KeyDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyPressEventArgs>> GetKeyPress (this TextBox el)
   {                        
       return Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>
           (   
		       h => new KeyPressEventHandler(h), 
               h => el.KeyPress += h, 
               h=> el.KeyPress -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyEventArgs>> GetKeyUp (this TextBox el)
   {                        
       return Observable.FromEvent<KeyEventHandler, KeyEventArgs>
           (   
		       h => new KeyEventHandler(h), 
               h => el.KeyUp += h, 
               h=> el.KeyUp -= h
            );          
   }
			
				
   public static IObservable<IEvent<LayoutEventArgs>> GetLayout (this TextBox el)
   {                        
       return Observable.FromEvent<LayoutEventHandler, LayoutEventArgs>
           (   
		       h => new LayoutEventHandler(h), 
               h => el.Layout += h, 
               h=> el.Layout -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLeave (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Leave += h, 
               h=> el.Leave -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLostFocus (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.LostFocus += h, 
               h=> el.LostFocus -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseDoubleClick (this TextBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseDoubleClick += h, 
               h=> el.MouseDoubleClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseCaptureChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseCaptureChanged += h, 
               h=> el.MouseCaptureChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseDown (this TextBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseDown += h, 
               h=> el.MouseDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseEnter (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseEnter += h, 
               h=> el.MouseEnter -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseLeave (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseLeave += h, 
               h=> el.MouseLeave -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseHover (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseHover += h, 
               h=> el.MouseHover -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseMove (this TextBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseMove += h, 
               h=> el.MouseMove -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseUp (this TextBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseUp += h, 
               h=> el.MouseUp -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseWheel (this TextBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseWheel += h, 
               h=> el.MouseWheel -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMove (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Move += h, 
               h=> el.Move -= h
            );          
   }
			
				
   public static IObservable<IEvent<PreviewKeyDownEventArgs>> GetPreviewKeyDown (this TextBox el)
   {                        
       return Observable.FromEvent<PreviewKeyDownEventHandler, PreviewKeyDownEventArgs>
           (   
		       h => new PreviewKeyDownEventHandler(h), 
               h => el.PreviewKeyDown += h, 
               h=> el.PreviewKeyDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetResize (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Resize += h, 
               h=> el.Resize -= h
            );          
   }
			
				
   public static IObservable<IEvent<UICuesEventArgs>> GetChangeUICues (this TextBox el)
   {                        
       return Observable.FromEvent<UICuesEventHandler, UICuesEventArgs>
           (   
		       h => new UICuesEventHandler(h), 
               h => el.ChangeUICues += h, 
               h=> el.ChangeUICues -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetStyleChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.StyleChanged += h, 
               h=> el.StyleChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetSystemColorsChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.SystemColorsChanged += h, 
               h=> el.SystemColorsChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<CancelEventArgs>> GetValidating (this TextBox el)
   {                        
       return Observable.FromEvent<CancelEventHandler, CancelEventArgs>
           (   
		       h => new CancelEventHandler(h), 
               h => el.Validating += h, 
               h=> el.Validating -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetValidated (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Validated += h, 
               h=> el.Validated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetParentChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ParentChanged += h, 
               h=> el.ParentChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetImeModeChanged (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ImeModeChanged += h, 
               h=> el.ImeModeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDisposed (this TextBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Disposed += h, 
               h=> el.Disposed -= h
            );          
   }
			
	}

public static class PictureBoxExtensions 
{
				
   public static IObservable<IEvent<EventArgs>> GetCausesValidationChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.CausesValidationChanged += h, 
               h=> el.CausesValidationChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetForeColorChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ForeColorChanged += h, 
               h=> el.ForeColorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetFontChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.FontChanged += h, 
               h=> el.FontChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetImeModeChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ImeModeChanged += h, 
               h=> el.ImeModeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<AsyncCompletedEventArgs>> GetLoadCompleted (this PictureBox el)
   {                        
       return Observable.FromEvent<AsyncCompletedEventHandler, AsyncCompletedEventArgs>
           (   
		       h => new AsyncCompletedEventHandler(h), 
               h => el.LoadCompleted += h, 
               h=> el.LoadCompleted -= h
            );          
   }
			
				
   public static IObservable<IEvent<ProgressChangedEventArgs>> GetLoadProgressChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<ProgressChangedEventHandler, ProgressChangedEventArgs>
           (   
		       h => new ProgressChangedEventHandler(h), 
               h => el.LoadProgressChanged += h, 
               h=> el.LoadProgressChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetRightToLeftChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.RightToLeftChanged += h, 
               h=> el.RightToLeftChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetSizeModeChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.SizeModeChanged += h, 
               h=> el.SizeModeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTabStopChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TabStopChanged += h, 
               h=> el.TabStopChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTabIndexChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TabIndexChanged += h, 
               h=> el.TabIndexChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTextChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TextChanged += h, 
               h=> el.TextChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetEnter (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Enter += h, 
               h=> el.Enter -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyEventArgs>> GetKeyUp (this PictureBox el)
   {                        
       return Observable.FromEvent<KeyEventHandler, KeyEventArgs>
           (   
		       h => new KeyEventHandler(h), 
               h => el.KeyUp += h, 
               h=> el.KeyUp -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyEventArgs>> GetKeyDown (this PictureBox el)
   {                        
       return Observable.FromEvent<KeyEventHandler, KeyEventArgs>
           (   
		       h => new KeyEventHandler(h), 
               h => el.KeyDown += h, 
               h=> el.KeyDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyPressEventArgs>> GetKeyPress (this PictureBox el)
   {                        
       return Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>
           (   
		       h => new KeyPressEventHandler(h), 
               h => el.KeyPress += h, 
               h=> el.KeyPress -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLeave (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Leave += h, 
               h=> el.Leave -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetAutoSizeChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.AutoSizeChanged += h, 
               h=> el.AutoSizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackColorChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackColorChanged += h, 
               h=> el.BackColorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackgroundImageChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackgroundImageChanged += h, 
               h=> el.BackgroundImageChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackgroundImageLayoutChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackgroundImageLayoutChanged += h, 
               h=> el.BackgroundImageLayoutChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBindingContextChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BindingContextChanged += h, 
               h=> el.BindingContextChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetClientSizeChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ClientSizeChanged += h, 
               h=> el.ClientSizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetContextMenuChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ContextMenuChanged += h, 
               h=> el.ContextMenuChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetContextMenuStripChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ContextMenuStripChanged += h, 
               h=> el.ContextMenuStripChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetCursorChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.CursorChanged += h, 
               h=> el.CursorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDockChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DockChanged += h, 
               h=> el.DockChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetEnabledChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.EnabledChanged += h, 
               h=> el.EnabledChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLocationChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.LocationChanged += h, 
               h=> el.LocationChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMarginChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MarginChanged += h, 
               h=> el.MarginChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetRegionChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.RegionChanged += h, 
               h=> el.RegionChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetSizeChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.SizeChanged += h, 
               h=> el.SizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetVisibleChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.VisibleChanged += h, 
               h=> el.VisibleChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetClick (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Click += h, 
               h=> el.Click -= h
            );          
   }
			
				
   public static IObservable<IEvent<ControlEventArgs>> GetControlAdded (this PictureBox el)
   {                        
       return Observable.FromEvent<ControlEventHandler, ControlEventArgs>
           (   
		       h => new ControlEventHandler(h), 
               h => el.ControlAdded += h, 
               h=> el.ControlAdded -= h
            );          
   }
			
				
   public static IObservable<IEvent<ControlEventArgs>> GetControlRemoved (this PictureBox el)
   {                        
       return Observable.FromEvent<ControlEventHandler, ControlEventArgs>
           (   
		       h => new ControlEventHandler(h), 
               h => el.ControlRemoved += h, 
               h=> el.ControlRemoved -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragDrop (this PictureBox el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragDrop += h, 
               h=> el.DragDrop -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragEnter (this PictureBox el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragEnter += h, 
               h=> el.DragEnter -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragOver (this PictureBox el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragOver += h, 
               h=> el.DragOver -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDragLeave (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DragLeave += h, 
               h=> el.DragLeave -= h
            );          
   }
			
				
   public static IObservable<IEvent<GiveFeedbackEventArgs>> GetGiveFeedback (this PictureBox el)
   {                        
       return Observable.FromEvent<GiveFeedbackEventHandler, GiveFeedbackEventArgs>
           (   
		       h => new GiveFeedbackEventHandler(h), 
               h => el.GiveFeedback += h, 
               h=> el.GiveFeedback -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetHandleCreated (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.HandleCreated += h, 
               h=> el.HandleCreated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetHandleDestroyed (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.HandleDestroyed += h, 
               h=> el.HandleDestroyed -= h
            );          
   }
			
				
   public static IObservable<IEvent<HelpEventArgs>> GetHelpRequested (this PictureBox el)
   {                        
       return Observable.FromEvent<HelpEventHandler, HelpEventArgs>
           (   
		       h => new HelpEventHandler(h), 
               h => el.HelpRequested += h, 
               h=> el.HelpRequested -= h
            );          
   }
			
				
   public static IObservable<IEvent<InvalidateEventArgs>> GetInvalidated (this PictureBox el)
   {                        
       return Observable.FromEvent<InvalidateEventHandler, InvalidateEventArgs>
           (   
		       h => new InvalidateEventHandler(h), 
               h => el.Invalidated += h, 
               h=> el.Invalidated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetPaddingChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.PaddingChanged += h, 
               h=> el.PaddingChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<PaintEventArgs>> GetPaint (this PictureBox el)
   {                        
       return Observable.FromEvent<PaintEventHandler, PaintEventArgs>
           (   
		       h => new PaintEventHandler(h), 
               h => el.Paint += h, 
               h=> el.Paint -= h
            );          
   }
			
				
   public static IObservable<IEvent<QueryContinueDragEventArgs>> GetQueryContinueDrag (this PictureBox el)
   {                        
       return Observable.FromEvent<QueryContinueDragEventHandler, QueryContinueDragEventArgs>
           (   
		       h => new QueryContinueDragEventHandler(h), 
               h => el.QueryContinueDrag += h, 
               h=> el.QueryContinueDrag -= h
            );          
   }
			
				
   public static IObservable<IEvent<QueryAccessibilityHelpEventArgs>> GetQueryAccessibilityHelp (this PictureBox el)
   {                        
       return Observable.FromEvent<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>
           (   
		       h => new QueryAccessibilityHelpEventHandler(h), 
               h => el.QueryAccessibilityHelp += h, 
               h=> el.QueryAccessibilityHelp -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDoubleClick (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DoubleClick += h, 
               h=> el.DoubleClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetGotFocus (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.GotFocus += h, 
               h=> el.GotFocus -= h
            );          
   }
			
				
   public static IObservable<IEvent<LayoutEventArgs>> GetLayout (this PictureBox el)
   {                        
       return Observable.FromEvent<LayoutEventHandler, LayoutEventArgs>
           (   
		       h => new LayoutEventHandler(h), 
               h => el.Layout += h, 
               h=> el.Layout -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLostFocus (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.LostFocus += h, 
               h=> el.LostFocus -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseClick (this PictureBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseClick += h, 
               h=> el.MouseClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseDoubleClick (this PictureBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseDoubleClick += h, 
               h=> el.MouseDoubleClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseCaptureChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseCaptureChanged += h, 
               h=> el.MouseCaptureChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseDown (this PictureBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseDown += h, 
               h=> el.MouseDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseEnter (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseEnter += h, 
               h=> el.MouseEnter -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseLeave (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseLeave += h, 
               h=> el.MouseLeave -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseHover (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseHover += h, 
               h=> el.MouseHover -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseMove (this PictureBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseMove += h, 
               h=> el.MouseMove -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseUp (this PictureBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseUp += h, 
               h=> el.MouseUp -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseWheel (this PictureBox el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseWheel += h, 
               h=> el.MouseWheel -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMove (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Move += h, 
               h=> el.Move -= h
            );          
   }
			
				
   public static IObservable<IEvent<PreviewKeyDownEventArgs>> GetPreviewKeyDown (this PictureBox el)
   {                        
       return Observable.FromEvent<PreviewKeyDownEventHandler, PreviewKeyDownEventArgs>
           (   
		       h => new PreviewKeyDownEventHandler(h), 
               h => el.PreviewKeyDown += h, 
               h=> el.PreviewKeyDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetResize (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Resize += h, 
               h=> el.Resize -= h
            );          
   }
			
				
   public static IObservable<IEvent<UICuesEventArgs>> GetChangeUICues (this PictureBox el)
   {                        
       return Observable.FromEvent<UICuesEventHandler, UICuesEventArgs>
           (   
		       h => new UICuesEventHandler(h), 
               h => el.ChangeUICues += h, 
               h=> el.ChangeUICues -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetStyleChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.StyleChanged += h, 
               h=> el.StyleChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetSystemColorsChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.SystemColorsChanged += h, 
               h=> el.SystemColorsChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<CancelEventArgs>> GetValidating (this PictureBox el)
   {                        
       return Observable.FromEvent<CancelEventHandler, CancelEventArgs>
           (   
		       h => new CancelEventHandler(h), 
               h => el.Validating += h, 
               h=> el.Validating -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetValidated (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Validated += h, 
               h=> el.Validated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetParentChanged (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ParentChanged += h, 
               h=> el.ParentChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDisposed (this PictureBox el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Disposed += h, 
               h=> el.Disposed -= h
            );          
   }
			
	}

public static class UserControlExtensions 
{
				
   public static IObservable<IEvent<EventArgs>> GetAutoSizeChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.AutoSizeChanged += h, 
               h=> el.AutoSizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetAutoValidateChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.AutoValidateChanged += h, 
               h=> el.AutoValidateChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLoad (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Load += h, 
               h=> el.Load -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTextChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TextChanged += h, 
               h=> el.TextChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<ScrollEventArgs>> GetScroll (this UserControl el)
   {                        
       return Observable.FromEvent<ScrollEventHandler, ScrollEventArgs>
           (   
		       h => new ScrollEventHandler(h), 
               h => el.Scroll += h, 
               h=> el.Scroll -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackColorChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackColorChanged += h, 
               h=> el.BackColorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackgroundImageChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackgroundImageChanged += h, 
               h=> el.BackgroundImageChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBackgroundImageLayoutChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BackgroundImageLayoutChanged += h, 
               h=> el.BackgroundImageLayoutChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetBindingContextChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.BindingContextChanged += h, 
               h=> el.BindingContextChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetCausesValidationChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.CausesValidationChanged += h, 
               h=> el.CausesValidationChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetClientSizeChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ClientSizeChanged += h, 
               h=> el.ClientSizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetContextMenuChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ContextMenuChanged += h, 
               h=> el.ContextMenuChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetContextMenuStripChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ContextMenuStripChanged += h, 
               h=> el.ContextMenuStripChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetCursorChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.CursorChanged += h, 
               h=> el.CursorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDockChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DockChanged += h, 
               h=> el.DockChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetEnabledChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.EnabledChanged += h, 
               h=> el.EnabledChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetFontChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.FontChanged += h, 
               h=> el.FontChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetForeColorChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ForeColorChanged += h, 
               h=> el.ForeColorChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLocationChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.LocationChanged += h, 
               h=> el.LocationChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMarginChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MarginChanged += h, 
               h=> el.MarginChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetRegionChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.RegionChanged += h, 
               h=> el.RegionChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetRightToLeftChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.RightToLeftChanged += h, 
               h=> el.RightToLeftChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetSizeChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.SizeChanged += h, 
               h=> el.SizeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTabIndexChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TabIndexChanged += h, 
               h=> el.TabIndexChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetTabStopChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.TabStopChanged += h, 
               h=> el.TabStopChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetVisibleChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.VisibleChanged += h, 
               h=> el.VisibleChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetClick (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Click += h, 
               h=> el.Click -= h
            );          
   }
			
				
   public static IObservable<IEvent<ControlEventArgs>> GetControlAdded (this UserControl el)
   {                        
       return Observable.FromEvent<ControlEventHandler, ControlEventArgs>
           (   
		       h => new ControlEventHandler(h), 
               h => el.ControlAdded += h, 
               h=> el.ControlAdded -= h
            );          
   }
			
				
   public static IObservable<IEvent<ControlEventArgs>> GetControlRemoved (this UserControl el)
   {                        
       return Observable.FromEvent<ControlEventHandler, ControlEventArgs>
           (   
		       h => new ControlEventHandler(h), 
               h => el.ControlRemoved += h, 
               h=> el.ControlRemoved -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragDrop (this UserControl el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragDrop += h, 
               h=> el.DragDrop -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragEnter (this UserControl el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragEnter += h, 
               h=> el.DragEnter -= h
            );          
   }
			
				
   public static IObservable<IEvent<DragEventArgs>> GetDragOver (this UserControl el)
   {                        
       return Observable.FromEvent<DragEventHandler, DragEventArgs>
           (   
		       h => new DragEventHandler(h), 
               h => el.DragOver += h, 
               h=> el.DragOver -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDragLeave (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DragLeave += h, 
               h=> el.DragLeave -= h
            );          
   }
			
				
   public static IObservable<IEvent<GiveFeedbackEventArgs>> GetGiveFeedback (this UserControl el)
   {                        
       return Observable.FromEvent<GiveFeedbackEventHandler, GiveFeedbackEventArgs>
           (   
		       h => new GiveFeedbackEventHandler(h), 
               h => el.GiveFeedback += h, 
               h=> el.GiveFeedback -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetHandleCreated (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.HandleCreated += h, 
               h=> el.HandleCreated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetHandleDestroyed (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.HandleDestroyed += h, 
               h=> el.HandleDestroyed -= h
            );          
   }
			
				
   public static IObservable<IEvent<HelpEventArgs>> GetHelpRequested (this UserControl el)
   {                        
       return Observable.FromEvent<HelpEventHandler, HelpEventArgs>
           (   
		       h => new HelpEventHandler(h), 
               h => el.HelpRequested += h, 
               h=> el.HelpRequested -= h
            );          
   }
			
				
   public static IObservable<IEvent<InvalidateEventArgs>> GetInvalidated (this UserControl el)
   {                        
       return Observable.FromEvent<InvalidateEventHandler, InvalidateEventArgs>
           (   
		       h => new InvalidateEventHandler(h), 
               h => el.Invalidated += h, 
               h=> el.Invalidated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetPaddingChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.PaddingChanged += h, 
               h=> el.PaddingChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<PaintEventArgs>> GetPaint (this UserControl el)
   {                        
       return Observable.FromEvent<PaintEventHandler, PaintEventArgs>
           (   
		       h => new PaintEventHandler(h), 
               h => el.Paint += h, 
               h=> el.Paint -= h
            );          
   }
			
				
   public static IObservable<IEvent<QueryContinueDragEventArgs>> GetQueryContinueDrag (this UserControl el)
   {                        
       return Observable.FromEvent<QueryContinueDragEventHandler, QueryContinueDragEventArgs>
           (   
		       h => new QueryContinueDragEventHandler(h), 
               h => el.QueryContinueDrag += h, 
               h=> el.QueryContinueDrag -= h
            );          
   }
			
				
   public static IObservable<IEvent<QueryAccessibilityHelpEventArgs>> GetQueryAccessibilityHelp (this UserControl el)
   {                        
       return Observable.FromEvent<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>
           (   
		       h => new QueryAccessibilityHelpEventHandler(h), 
               h => el.QueryAccessibilityHelp += h, 
               h=> el.QueryAccessibilityHelp -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDoubleClick (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.DoubleClick += h, 
               h=> el.DoubleClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetEnter (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Enter += h, 
               h=> el.Enter -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetGotFocus (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.GotFocus += h, 
               h=> el.GotFocus -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyEventArgs>> GetKeyDown (this UserControl el)
   {                        
       return Observable.FromEvent<KeyEventHandler, KeyEventArgs>
           (   
		       h => new KeyEventHandler(h), 
               h => el.KeyDown += h, 
               h=> el.KeyDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyPressEventArgs>> GetKeyPress (this UserControl el)
   {                        
       return Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>
           (   
		       h => new KeyPressEventHandler(h), 
               h => el.KeyPress += h, 
               h=> el.KeyPress -= h
            );          
   }
			
				
   public static IObservable<IEvent<KeyEventArgs>> GetKeyUp (this UserControl el)
   {                        
       return Observable.FromEvent<KeyEventHandler, KeyEventArgs>
           (   
		       h => new KeyEventHandler(h), 
               h => el.KeyUp += h, 
               h=> el.KeyUp -= h
            );          
   }
			
				
   public static IObservable<IEvent<LayoutEventArgs>> GetLayout (this UserControl el)
   {                        
       return Observable.FromEvent<LayoutEventHandler, LayoutEventArgs>
           (   
		       h => new LayoutEventHandler(h), 
               h => el.Layout += h, 
               h=> el.Layout -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLeave (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Leave += h, 
               h=> el.Leave -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetLostFocus (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.LostFocus += h, 
               h=> el.LostFocus -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseClick (this UserControl el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseClick += h, 
               h=> el.MouseClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseDoubleClick (this UserControl el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseDoubleClick += h, 
               h=> el.MouseDoubleClick -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseCaptureChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseCaptureChanged += h, 
               h=> el.MouseCaptureChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseDown (this UserControl el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseDown += h, 
               h=> el.MouseDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseEnter (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseEnter += h, 
               h=> el.MouseEnter -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseLeave (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseLeave += h, 
               h=> el.MouseLeave -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMouseHover (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.MouseHover += h, 
               h=> el.MouseHover -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseMove (this UserControl el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseMove += h, 
               h=> el.MouseMove -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseUp (this UserControl el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseUp += h, 
               h=> el.MouseUp -= h
            );          
   }
			
				
   public static IObservable<IEvent<MouseEventArgs>> GetMouseWheel (this UserControl el)
   {                        
       return Observable.FromEvent<MouseEventHandler, MouseEventArgs>
           (   
		       h => new MouseEventHandler(h), 
               h => el.MouseWheel += h, 
               h=> el.MouseWheel -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetMove (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Move += h, 
               h=> el.Move -= h
            );          
   }
			
				
   public static IObservable<IEvent<PreviewKeyDownEventArgs>> GetPreviewKeyDown (this UserControl el)
   {                        
       return Observable.FromEvent<PreviewKeyDownEventHandler, PreviewKeyDownEventArgs>
           (   
		       h => new PreviewKeyDownEventHandler(h), 
               h => el.PreviewKeyDown += h, 
               h=> el.PreviewKeyDown -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetResize (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Resize += h, 
               h=> el.Resize -= h
            );          
   }
			
				
   public static IObservable<IEvent<UICuesEventArgs>> GetChangeUICues (this UserControl el)
   {                        
       return Observable.FromEvent<UICuesEventHandler, UICuesEventArgs>
           (   
		       h => new UICuesEventHandler(h), 
               h => el.ChangeUICues += h, 
               h=> el.ChangeUICues -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetStyleChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.StyleChanged += h, 
               h=> el.StyleChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetSystemColorsChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.SystemColorsChanged += h, 
               h=> el.SystemColorsChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<CancelEventArgs>> GetValidating (this UserControl el)
   {                        
       return Observable.FromEvent<CancelEventHandler, CancelEventArgs>
           (   
		       h => new CancelEventHandler(h), 
               h => el.Validating += h, 
               h=> el.Validating -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetValidated (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Validated += h, 
               h=> el.Validated -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetParentChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ParentChanged += h, 
               h=> el.ParentChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetImeModeChanged (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.ImeModeChanged += h, 
               h=> el.ImeModeChanged -= h
            );          
   }
			
				
   public static IObservable<IEvent<EventArgs>> GetDisposed (this UserControl el)
   {                        
       return Observable.FromEvent<EventHandler, EventArgs>
           (   
		       h => new EventHandler(h), 
               h => el.Disposed += h, 
               h=> el.Disposed -= h
            );          
   }
			
	}

}