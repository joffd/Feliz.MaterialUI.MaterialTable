﻿namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type options =
    /// Actions cell style
    static member inline actionsCellStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "actionsCellStyle" (createObj !!props)
    /// Order of actions column
    static member inline actionsColumnIndex (value: int) = Interop.mkOptionsAttr "actionsColumnIndex" value
    /// Flag for columns button that controls which column could be rendered
    static member inline columnsButton (value: bool) = Interop.mkOptionsAttr "columnsButton" value
    /// Debounce interval for search and filter
    static member inline debounceInterval (value: int) = Interop.mkOptionsAttr "debounceInterval" value
    /// Debounce interval for search and filter
    static member inline debounceInterval (value: float) = Interop.mkOptionsAttr "debounceInterval" value
    /// Flag for double scroll bar for long tables
    static member inline doubleHorizontalScroll (value: bool) = Interop.mkOptionsAttr "doubleHorizontalScroll" value
    /// Flag for rendering rows to complete page size
    static member inline emptyRowsWhenPaging (value: bool) = Interop.mkOptionsAttr "emptyRowsWhenPaging" value
    /// Flag for export all data instead of rendered data
    static member inline exportAllData (value: bool) = Interop.mkOptionsAttr "exportAllData" value
    /// Flag for export button that render export buttons
    static member inline exportButton (value: bool) = Interop.mkOptionsAttr "exportButton" value
    /// Delimiter to use in exported CSV file
    static member inline exportDelimiter (value: string) = Interop.mkOptionsAttr "exportDelimiter" value
    /// Exported file name
    static member inline exportFileName (value: string) = Interop.mkOptionsAttr "exportFileName" value
    /// Function to create a custom CSV file
    static member inline exportCsv (value: obj -> unit) = Interop.mkOptionsAttr "exportCsv" value
    /// Flag for filtering row
    static member inline filtering (value: bool) = Interop.mkOptionsAttr "filtering" value
    /// Filter cell style for all filter cells
    static member inline filterCellStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "filterCellStyle" (createObj !!props)
    /// Flag for groupbar visibility
    static member inline grouping (value: bool) = Interop.mkOptionsAttr "grouping" value
    /// Flag for header visibility
    static member inline header (value: bool) = Interop.mkOptionsAttr "header" value
    /// Header cell style for all headers
    static member inline headerStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "headerStyle" (createObj !!props)
    /// Max body height
    static member inline maxBodyHeight (value: int) = Interop.mkOptionsAttr "maxBodyHeight" value
    /// Max body height
    static member inline maxBodyHeight (value: float) = Interop.mkOptionsAttr "maxBodyHeight" value
    /// Max body height
    static member inline maxBodyHeight (value: Feliz.Styles.ICssUnit) = Interop.mkOptionsAttr "maxBodyHeight" value
    /// Min body height
    static member inline minBodyHeight (value: int) = Interop.mkOptionsAttr "minBodyHeight" value
    /// Min body height
    static member inline minBodyHeight (value: float) = Interop.mkOptionsAttr "minBodyHeight" value
    /// Min body height
    static member inline minBodyHeight (value: Feliz.Styles.ICssUnit) = Interop.mkOptionsAttr "minBodyHeight" value
    /// Initial Page Number
    static member inline initialPage (value: int) = Interop.mkOptionsAttr "initialPage" value
    /// Flag for paging feature
    static member inline paging (value: bool) = Interop.mkOptionsAttr "paging" value
    /// Number of rows that would be rendered on every page
    static member inline pageSize (value: int) = Interop.mkOptionsAttr "pageSize" value
    /// Page size options that could be selected by user
    static member inline pageSizeOptions (value: int []) = Interop.mkOptionsAttr "pageSizeOptions" (value |> ResizeArray)
    /// Page size options that could be selected by user
    static member inline pageSizeOptions (value: int list) = Interop.mkOptionsAttr "pageSizeOptions" (value |> ResizeArray)
    /// Page size options that could be selected by user
    static member inline pageSizeOptions (value: int seq) = Interop.mkOptionsAttr "pageSizeOptions" (value |> ResizeArray)
    /// Css style to be applied rows
    static member inline rowStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "rowStyle" (createObj !!props)
    /// Flag for showing message if there is no data in table
    static member inline showEmptyDataSourceMessage (value: bool) = Interop.mkOptionsAttr "showEmptyDataSourceMessage" value
    /// Flag for showing first and last page buttons on pagination component
    static member inline showFirstLastPageButtons (value: bool) = Interop.mkOptionsAttr "showFirstLastPageButtons" value
    /// Flag for showing select all checkbox
    static member inline showSelectAllCheckbox (value: bool) = Interop.mkOptionsAttr "showSelectAllCheckbox" value
    /// Flag for showing selected rows text on toolbar
    static member inline showTextRowsSelected (value: bool) = Interop.mkOptionsAttr "showTextRowsSelected" value
    /// Flag for search feature
    static member inline search (value: bool) = Interop.mkOptionsAttr "search" value
    /// Search field css style
    static member inline searchFieldStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "searchFieldStyle" (createObj !!props)
    /// Flag for selection feature
    static member inline selection (value: bool) = Interop.mkOptionsAttr "selection" value
    /// Selection checkbox props
    static member inline selectionProps (value: obj option) = Interop.mkOptionsAttr "selectionProps" value
    /// Selection checkbox props
    static member inline selectionProps (value: obj option -> obj option) = Interop.mkOptionsAttr "selectionProps" value
    /// Flag to activate or disable sorting feature of table
    static member inline sorting (value: bool) = Interop.mkOptionsAttr "sorting" value
    /// Flag for toolbar
    static member inline toolbar (value: bool) = Interop.mkOptionsAttr "toolbar" value
    /// Flag for title
    static member inline showTitle (value: bool) = Interop.mkOptionsAttr "showTitle" value
    /// Flag for drag and drop headers
    static member inline draggable (value: bool) = Interop.mkOptionsAttr "draggable" value

module options =
    /// Position of add row
    [<Erase>]
    type addRowPosition =
        static member inline first = Interop.mkOptionsAttr "addRowPosition" "first"
        static member inline last = Interop.mkOptionsAttr "addRowPosition" "last"

    /// Detail panel column alignment.
    [<Erase>]
    type detailPanelColumnAlignment =
        static member inline left = Interop.mkOptionsAttr "detailPanelColumnAlignment" "left"
        static member inline right = Interop.mkOptionsAttr "detailPanelColumnAlignment" "right"

    /// Detail panel visibility type.
    [<Erase>]
    type detailPanelType =
        static member inline single = Interop.mkOptionsAttr "detailPanelType" "single"
        static member inline multiple = Interop.mkOptionsAttr "detailPanelType" "multiple"

    /// Detail panel visibility type.
    [<Erase>]
    type loadingType =
        static member inline overlay = Interop.mkOptionsAttr "loadingType" "overlay"
        static member inline linear = Interop.mkOptionsAttr "loadingType" "linear"

    /// Detail panel visibility type.
    [<Erase>]
    type padding =
        static member inline default' = Interop.mkOptionsAttr "padding" "default"
        static member inline dense = Interop.mkOptionsAttr "padding" "dense"

    /// Flag for pagination type
    [<Erase>]
    type paginationType =
        static member inline normal = Interop.mkOptionsAttr "paginationType" "normal"
        static member inline stepped = Interop.mkOptionsAttr "paginationType" "stepped"

    /// Flag for pagination type
    [<Erase>]
    type searchFieldAlignment =
        static member inline left = Interop.mkOptionsAttr "searchFieldAlignment" "left"
        static member inline right = Interop.mkOptionsAttr "searchFieldAlignment" "right"

    /// Flag for pagination type
    [<Erase>]
    type toolbarButtonAlignment =
        static member inline left = Interop.mkOptionsAttr "toolbarButtonAlignment" "left"
        static member inline right = Interop.mkOptionsAttr "toolbarButtonAlignment" "right"
