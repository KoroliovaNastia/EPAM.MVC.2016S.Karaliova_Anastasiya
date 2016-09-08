function setSide(side) {
    
    //$(".navbar-inverse").toggleClass('.light');
    //$(".navbar-inverse").toggleClass('.dark');

    if (side === "Light") {

        $(".container").addClass("light");
        $(".logoSide").addClass("light");
        $(".container").fadeTo(1000, 0.7);

    } else {
        $(".container").removeClass("light");
        $(".container").addClass("dark");
        $(".container").fadeTo(1000, 0.7);
        $(".logoSide").removeClass("light");
        $(".logoSide").addClass("dark");
        $("#btnChangeSide").click(function () {
            alert("LOL. There is no way out!\nP.S. Your HR Departament has been contacted.");
        });
    }
}