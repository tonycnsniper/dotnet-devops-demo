import { ReactNode } from "react";
import Navbar from "./Navbar";
import Modal from "./Modal";

type Props = {
  children: ReactNode;
};

export default function Layout({ children }: Props) {
  return (
    <>
      <Navbar />
      <div className="container pt-16">
        <div className="inner container max-w-screen-md mx-auto pt-2">
          {children}
        </div>
        <div className="flex items-center justify-center h-screen">
          <button className="py-2 px-6 bg-blue-500 text-white rounded hover:bg-blue-700 transition font-medium duration-500">SHOW MODAL</button>
        </div>
        <Modal />
      </div>
    </>
  );
}
