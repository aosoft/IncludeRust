extern crate cbindgen;

use std::env;
use std::path::PathBuf;


fn main() {
    let crate_dir = env::var("CARGO_MANIFEST_DIR").unwrap();
    let header_dir = PathBuf::from(env::var("CARGO_MANIFEST_DIR").unwrap()).join("Public");

    let package_name = env::var("CARGO_PKG_NAME").unwrap();
    let output_file = header_dir
        .join(format!("{}.h", package_name))
        .display()
        .to_string();

    cbindgen::generate_with_config(&crate_dir, Default::default())
        .unwrap()
        .write_to_file(&output_file);
}
