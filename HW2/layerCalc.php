<?php include ('layouts/header.php'); ?>


    <center>
        <h1>3D Printing Layer Calculator</h1>
    </center>
    <br />
    <div id="calc" class="row">
        <div class="col-md-12">
            <form action="" class="form-inline">
                <div class="form-group">
                    <!-- has-error has-feedback -->
                    <label for="printers">3D Printer: </label>
                    <select name="printer-select" id="printers" class="form-control">
                        <option value="hoose">Please select a printer </option>
                        <option value="cube">Cube Pro</option>
                        <option value="makerbot">Makerbot</option>
                        <option value="ultimaker">Ultimaker</option>
                        <option value="unknown">Unknown</option>
                    </select>
                </div>
                <div id="height-input" class="form-group">
                    <!-- has-error has-feedback -->
                    <label for="height">Height: </label>
                    <input type="text" class="form-control" id="height" placeholder="Enter desired height">
                    <span class="glyphicon glyphicon-remove form-control-feedback hidden"></span>
                </div>
                <div class="form-group radio">
                    <label for="radio-unit" class="radio-inline">
                        <input type="radio" name="radio-unit" checked>in
                    </label>
                    <label for="radio-unit" class="radio-inline">
                        <input type="radio" name="radio-unit">cm
                    </label>
                </div>
                <div class="form-group">
                    <button type="submit" class="btn btn-primary">Calculate</button>
                </div>
            </form>
            <span class="help-block hidden">Error text goes here</span>
        </div>
    </div>

    <?php include ('layouts/footer.php'); ?>