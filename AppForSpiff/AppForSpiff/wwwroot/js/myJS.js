function Print() {
    // Hide elements before printing
    $(".hideWhenPrint").hide();

    // Add a listener for after the print dialog closes
    window.onafterprint = function () {
        $(".hideWhenPrint").show();  // Show elements again after printing
    };

    // Open the print dialog
    window.print();
}
